using Microsoft.EntityFrameworkCore;
using Khademi.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Khademi.DAL
{
    public class DatabaseContext : IdentityDbContext
    {

        public DbSet<MovieEntity> Movies { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieEntity>().HasData(SeedData.Movies);
            modelBuilder.Entity<IdentityRole>().HasData(SeedData.Roles);
        }
    }
}
