using GigHub.Models;
using GigHub.ViewModels;
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

        
    }
}