using Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _002_AutnenticationWithIdentity.Models
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<MovieModel> Movies { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Email = "mt.khademi@gmail.com",
                    UserName = "mt.khademi",
                    PasswordHash = "123"
                });

        }
    }
}
