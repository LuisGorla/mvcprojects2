using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        //string because everithing that the user puts in the form is a string. Later we will be parsing this string into objects of different types
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }


        [Required]
        public byte Genre { get; set; }//with dropdown list we need numeric value for each option

        public IEnumerable<Genre> Genres { get; set; }
        public DateTime GetDateTime()
        { 

            
                return DateTime.Parse(string.Format("{0} {1}", Date, Time));
                //Because we are inside the viewModel, i dont need viewmodel.something
                //DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                //associate gig with genre object, similar to artist, we need to read it from the database first
                //Here we are making the controller responsable of parsint a string into datetime object. The class who knows about dates and time should be the one parsing, in this case viewModel
            
        }
    }
}