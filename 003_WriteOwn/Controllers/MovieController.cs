using _003_WriteOwn.Extenttions;
using _003_WriteOwn.Models;
using _003_WriteOwn.Models.Movie;
using Microsoft.AspNetCore.Mvc;

namespace _003_WriteOwn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController(DatabaseContext _context) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddNewMovie([FromBody] MovieAddDto addDto)
        {
            //-- Validation input

            //-- Validation login and business

            //-- Map data to own model

            //-- add
            await _context.Movies.AddAsync(addDto.ToMovieModel());
            await _context.SaveChangesAsync();

            //-- return result
            return Ok();
        }
    }
}
