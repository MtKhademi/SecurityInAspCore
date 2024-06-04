using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MrMohande3Khademi.DAL;

namespace MrMohande3Khademi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController(
        DatabaseContext _context) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetRoles() => Ok(await _context.Roles.ToListAsync());
    }
}
