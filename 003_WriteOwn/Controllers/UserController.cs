using _003_WriteOwn.Extenttions;
using _003_WriteOwn.Models;
using _003_WriteOwn.Models.User;
using _003_WriteOwn.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace _003_WriteOwn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(
        DatabaseContext _context,
        IHandleAccessToken<UserModel> _handleAccessToken) : ControllerBase
    {
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] UserRegisterDto userRegisterDto)
        {
            var user = userRegisterDto.ToUserModel();
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

            return Ok(_handleAccessToken.GetAccessToken(user));
        }

        [HttpGet("GetCurrectUser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var token = Request.Headers["AUTH-CUS"];
            return Ok(_handleAccessToken.GetModelFromAccessToken(token));
        }

    }
}
