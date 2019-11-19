using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        // GET: Gigs
        private readonly ApplicationDbContext _context;
        
        public GigsController()
        {
            _context = new ApplicationDbContext(); // What about dependency injection and the repository pattern?
        }

        [Authorize] // this atribute will let only registered users create content
        public ActionResult Create()
        {
            //To list the genres in the listbox we need to populate the Genres property in the View Model, and this is the job of the controller 
            //We need the list of genres from the database, for this we need the DbContext

            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            //This view model inside the view

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]// we want this attribute to only be called by an httppost method
        public ActionResult Create(GigFormViewModel viewModel)
        {
            //convert viewModel to GigObject, add it to context and save changes

            var gig = new Gig // So each gig has an artist, a DateTime, a Genre and a Venue (place), this is a Gig object
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),//DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                //associate gig with genre object, similar to artist, we need to read it from the database first
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue


            };

            _context.Gigs.Add(gig); //  add the gig object
            _context.SaveChanges(); //  save the gig object

            //Redirecting to home page
            // name of action, controller
            return RedirectToAction("Index", "Home");

        }
    }
}