using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Api.Movie
{
    public class MovieController : ControllerBase
    { 

        [HttpGet]
        public async Task<IEnumerable<Movie>> GetMoviews()
        {
            return null;
        }

    }
}
