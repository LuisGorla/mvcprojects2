using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        //string because everithing that the user puts in the form is a string. Later we will be parsing this string into objects of different types

        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }


        //with dropdown list we need numeric value for each option
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}