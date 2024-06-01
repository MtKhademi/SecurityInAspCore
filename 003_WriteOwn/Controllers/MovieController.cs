using _003_WriteOwn.AUTH;
using _003_WriteOwn.Extenttions;
using _003_WriteOwn.Models;
using _003_WriteOwn.Models.Movie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _003_WriteOwn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class MovieController(DatabaseContext _context) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddNewMovie([FromBody] MovieAddDto addDto)
        {
            await _context.Movies.AddAsync(addDto.ToMovieModel());
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
            => Ok(await _context.Movies.ToListAsync());

        [HttpDelete("{movieId}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int movieId)
        {
            _context.Movies.Remove(await _context.Movies.FindAsync(movieId));
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
