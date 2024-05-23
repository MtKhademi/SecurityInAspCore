using Common;
using Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _001_AuthenticationWays_BuiltIn.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    //[Authorize]
    [Authorize(Roles ="Administrator,Seller")]
    public class MovieWithAuthenticationController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<MovieModel> Gets() => DatabaseContext.Movies;

        [HttpPost]
        public void Add(MovieModel movie) => DatabaseContext.Movies.Add(movie);

        [HttpDelete]
        public void Delete(int movieId)
            => DatabaseContext.Movies.Remove(DatabaseContext.Movies.SingleOrDefault(x => x.Id == movieId));

    }
}
