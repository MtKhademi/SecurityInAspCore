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

            base.OnModelCreating(builder);


            builder.Entity<IdentityRole>().HasData(
                new IdentityRole("administrator"),
                new IdentityRole("seller"),
                new IdentityRole("user")
            );


            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "mt.khademi@gmail.com",
                    NormalizedEmail = "mt.khademi@gmail.com",
                    UserName = "mt.khademi",
                    PasswordHash = "123"
                },
                new IdentityUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "mt.khademi2@gmail.com",
                    NormalizedEmail = "mt.khademi2@gmail.com",
                    UserName = "mt.khademi2",
                    PasswordHash = "123"
                });

        }
    }
}
