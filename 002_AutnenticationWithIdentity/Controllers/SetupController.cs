using _002_AutnenticationWithIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _002_AutnenticationWithIdentity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SetupController(
        DatabaseContext _context,
        UserManager<IdentityUser> _userManagement,
        RoleManager<IdentityRole> _roleManagement,
        ILogger<SetupController> _logger) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            return Ok(await _context.Roles.ToListAsync());
        }
    }
}
