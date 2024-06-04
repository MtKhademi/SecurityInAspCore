using Microsoft.EntityFrameworkCore;
using MrMohande3Khademi.DAL.Entities;

namespace MrMohande3Khademi.DAL
{
    public class DatabaseContext : DbContext
    {

        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieEntity>().HasData(SeedData.Movies);
            modelBuilder.Entity<RoleEntity>().HasData(SeedData.Roles);
        }
    }
}
