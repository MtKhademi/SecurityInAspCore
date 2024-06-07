using MrMohande3Khademi.Extenttions;
using MrMohande3Khademi.Models.Movie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MrMohande3Khademi.Services;
using MrMohande3Khademi.DAL;

namespace MrMohande3Khademi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController(DatabaseContext _context,
        IAccessControllerService _accessControllerService) : ControllerBase
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
            if (!_accessControllerService.IsAuthenticated)
                return new StatusCodeResult(StatusCodes.Status401Unauthorized);
            if (!_accessControllerService.IsAuthrozied)
                return new StatusCodeResult(StatusCodes.Status403Forbidden);

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
