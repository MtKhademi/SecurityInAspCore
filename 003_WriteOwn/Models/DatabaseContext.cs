using _003_WriteOwn.Models.Movie;
using _003_WriteOwn.Models.User;
using Microsoft.EntityFrameworkCore;

namespace _003_WriteOwn.Models
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Movie.Movie> Movies { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie.Movie>().HasData(
                [
                    new Movie.Movie()
                    {
                        Id = 1,
                        CreateDateTime = DateTime.Now,
                        Description="",
                        CreatedBy = "Mt.khademi",
                        IsDeleted = false,
                        Name = "Movie 001",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    },
                    new Movie.Movie()
                    {
                        Id = 2,
                        CreateDateTime = DateTime.Now,
                        Description="",
                        CreatedBy = "Brother warner",
                        IsDeleted = false,
                        Name = "Movie 002",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    },
                    new Movie.Movie()
                    {
                        Id = 3,
                        CreateDateTime = DateTime.Now,
                        Description="",
                        CreatedBy = "Pixar",
                        IsDeleted = false,
                        Name = "Movie 003",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    },
                    new Movie.Movie()
                    {
                        Id = 4,
                        CreateDateTime = DateTime.Now,
                        Description="",
                        CreatedBy = "Alibaba",
                        IsDeleted = false,
                        Name = "Movie 004",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    },
                    new Movie.Movie()
                    {
                        Id = 5,
                        CreateDateTime = DateTime.Now,
                        Description="",
                        CreatedBy = "Vedio Full intertanment",
                        IsDeleted = false,
                        Name = "Movie 005",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    }

                ]);
        }
    }
}
