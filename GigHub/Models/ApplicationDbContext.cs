using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace GigHub.Models
{


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public DbSet<Gig> Gigs { get; set; }
            // If i want to query Genre I need a Dbset, as a resume, anything I want to query needs a Dbset
            public DbSet<Genre> Genres { get; set; }
            public ApplicationDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }
    
}