using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<category> Categories { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<appUser> users { get; set; }
        public DbSet<contact> contacts{ get; set; }
        public DbSet<Galeri> galleri { get; set; }


    }
}
