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

        [HttpPost("Users/Add")]
        public async Task<IActionResult> AddNewUser([FromBody] IdentityUser user)
        {
            await _context.Users.AddAsync(user);
            return Ok();
        }

        [HttpPost("Users/AddToARole")]
        public async Task<IActionResult> UserAddToARole([FromQuery] string email, [FromQuery] string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("role name can not be null");
            if (string.IsNullOrWhiteSpace(email))
                return BadRequest("email can not be null");

            _logger.LogWarning("Role name is : {0}", roleName);
            _logger.LogWarning("Email is : {0}", email);

            var role = await _roleManagement.FindByNameAsync(roleName);
            if (role is null)
                return BadRequest("not exist this role");


            var user = await _userManagement.FindByIdAsync(email);
            if (user is null)
                return BadRequest($"not exist such user with this email : {email}");

            await _userManagement.AddToRoleAsync(user, roleName);
            return Ok("success user to a new role");
        }

    }
}
