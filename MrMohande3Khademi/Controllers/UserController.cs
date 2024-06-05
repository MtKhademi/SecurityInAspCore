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
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] UserRegisterDto userRegisterDto)
        {
            var user = userRegisterDto.ToUserEntity();
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] UserLoginDto userLoginDto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(
                us => us.UserName == userLoginDto.UserName && us.Password == userLoginDto.Password);
            if (user is null)
                return NotFound($"not exist this user : {userLoginDto}");

            return Ok(await _accessControllerService.CreateAccessTokenAsync(user.ToUserModel()));
        }

        [HttpGet("GetCurrectUser")]
        public IActionResult GetCurrentUser()
        {
            return Ok(_accessControllerService.CurrentUser);
        }

    }
}
