using Khademi.Extenttions;
using Khademi.Models.Movie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Khademi.DAL;
using Microsoft.AspNetCore.Authorization;

namespace Khademi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "administrator")]
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
        {
            return Ok(await _context.Movies.ToListAsync());
        }

        [HttpDelete("{movieId}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int movieId)
        {
            _context.Movies.Remove(await _context.Movies.FindAsync(movieId));
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
