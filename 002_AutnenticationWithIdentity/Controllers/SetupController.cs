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

        [HttpGet("Roles")]
        public async Task<IActionResult> GetAllRoles()
        {
            return Ok(await _context.Roles.ToListAsync());
        }


        [HttpPost("Roles/Add")]
        public async Task<IActionResult> AddNewRole([FromBody] string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("role name can not be null or empty");

            roleName = roleName.Trim().ToLower();
            var isExistAlreadyThisRoleName = await _roleManagement.RoleExistsAsync(roleName);

            if (isExistAlreadyThisRoleName)
                return BadRequest("role name already exist");

            await _roleManagement.CreateAsync(new IdentityRole(roleName));
            return Ok();
        }

        [HttpDelete("Roles/Delete")]
        public async Task<IActionResult> DeleteRole([FromBody] string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("role name can not be null or empty");

            roleName = roleName.Trim().ToLower();
            var isExistAlreadyThisRoleName = await _roleManagement.RoleExistsAsync(roleName);

            if (!isExistAlreadyThisRoleName)
                return BadRequest("role name not exist");

            var role = await _roleManagement.FindByNameAsync(roleName);
            await _roleManagement.DeleteAsync(role);
            return Ok($"delete {roleName} is successfuled");
        }


        [HttpGet("Users")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _context.Users.ToListAsync());
        }

    }
}
