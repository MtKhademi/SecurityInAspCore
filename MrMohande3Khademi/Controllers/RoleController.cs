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

        [HttpGet("GetRoles")]
        public async Task<IActionResult> GetRoles()
            => Ok(await _context.Roles.ToListAsync());

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers([FromQuery] string roleName)
            => Ok(await _context.Users
                .Include(us => us.Roles)
                //.ThenInclude(ro => ro.Role)
                //.Where(us => us.Roles.Any(r => r.Role.Name.Contains(roleName)))
                .ToListAsync());




    }
}
