using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        
        
        public int Id { get; set; }
       
        //Required make this attributes or propperties not null AKA cant be null/ not nullable
        [Required]
        public ApplicationUser Artist { get; set; }
       
        public DateTime DateTime { get; set; }


        [Required]
        //I want lo limit this fields to 250 characters so..
        [StringLength(255)]
        public string Venue { get; set; }

        //Each required attribute means a line break
        [Required]
        public Genre Genre { get; set; }
    }
}