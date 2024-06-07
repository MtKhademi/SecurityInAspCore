using MrMohande3Khademi.Extenttions;
using MrMohande3Khademi.Models.User;
using MrMohande3Khademi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using MrMohande3Khademi.DAL;

namespace MrMohande3Khademi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(
        DatabaseContext _context,
        IAccessControllerService _accessControllerService) : ControllerBase
    {
        [HttpGet("GetRoles")]
        public async Task<IActionResult> GetRoles([FromQuery] string userName)
        {
            var user = await _context.Users
                //.Include(ur => ur.Roles)
                //.ThenInclude(r => r.Role)
                .SingleOrDefaultAsync(us => us.UserName == userName);
            //return Ok(user.Roles.Select(x => x.Role).ToList());

            return Ok();
        }

        [HttpPost("AddNewRoleToUser")]
        public async Task<IActionResult> AddNewRoleToUser([FromQuery] string userName, [FromQuery] string roleName)
        {
            roleName = roleName.Trim().ToLower();
            userName = userName.Trim().ToLower();

            var role = await _context.Roles.SingleOrDefaultAsync(x => x.Name == roleName);
            var user = await _context.Users
                .Include(r => r.Roles)
                //.ThenInclude(rr => rr.Role)
                .SingleOrDefaultAsync(us => us.UserName == userName);


            //if (user.Roles.Any(x => x.Role.Name == roleName))
            //    return Ok();

            //user.Roles.Add(new DAL.Entities.UserRoleEntity
            //{

            //    Role = role!,
            //    RoleId = role!.Id
            //});
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
