using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Khademi.DAL;
using Microsoft.AspNetCore.Identity;

namespace Khademi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController(
        DatabaseContext _context,
        UserManager<IdentityUser> _userManager,
        RoleManager<IdentityRole> _roleManager) : ControllerBase
    {

        [HttpGet("GetRoles")]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await _roleManager.Roles.ToListAsync());
        }


        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers([FromQuery] string roleName)
        {
            return Ok(await _userManager.GetUsersInRoleAsync(roleName));
        }
    }
}
