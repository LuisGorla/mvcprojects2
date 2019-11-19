using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        
        
        public int Id { get; set; }
       
        //Required make this attributes or propperties not null AKA cant be null/ not nullable
        public ApplicationUser Artist { get; set; }

        //Required make this attributes or propperties not null AKA cant be null/ not nullable
        [Required]

        //This FK property is string because ID in ApplicationUser(wich is an ASP.NET identity class) is define as String as string 
        public string ArtistId { get; set; }
        public DateTime DateTime { get; set; }


        [Required]
        //I want lo limit this fields to 250 characters so..
        [StringLength(255)]
        public string Venue { get; set; }

        
        public Genre Genre { get; set; }
        //Each required attribute means a line break
        [Required]
        public byte GenreId { get; set; }
    }
}