using Microsoft.AspNetCore.Mvc;
using Khademi.DAL;
using Microsoft.AspNetCore.Identity;

namespace Khademi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(
        DatabaseContext _context,
        UserManager<IdentityUser> _userManager,
        RoleManager<IdentityRole> _roleManager) : ControllerBase
    {
        [HttpGet("GetRoles")]
        public async Task<IActionResult> GetRoles([FromQuery] string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            return Ok(await _userManager.GetRolesAsync(user));
        }

        [HttpPost("AddToRole")]
        public async Task<IActionResult> AddNewRoleToUser([FromQuery] string userName, [FromQuery] string roleName)
        {
            roleName = roleName.Trim().ToLower();
            userName = userName.Trim().ToLower();

            var user = await _userManager.FindByNameAsync(userName);
            var role = await _roleManager.FindByNameAsync(roleName);

            await _userManager.AddToRoleAsync(user, roleName);

            return Ok();
        }

        [HttpPost("RemoveFromRole")]
        public async Task<IActionResult> RemoveFromRole([FromQuery] string userName, [FromQuery] string roleName)
        {
            roleName = roleName.Trim().ToLower();
            userName = userName.Trim().ToLower();

            var user = await _userManager.FindByNameAsync(userName);
            var role = await _roleManager.FindByNameAsync(roleName);

            await _userManager.RemoveFromRoleAsync(user, roleName);

            return Ok();
        }

    }
}
