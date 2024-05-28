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
    }
}
