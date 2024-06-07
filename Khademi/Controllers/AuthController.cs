using Khademi;
using Khademi.DAL;
using Khademi.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MrMohande3Khademi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController(
        DatabaseContext _context,
        UserManager<IdentityUser> _userManager,
        RoleManager<IdentityUser> _roleManager,
        IAccessControllerService _accessControllerService) : ControllerBase
    {

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] UserRegisterDto userRegisterDto)
        {
            await _userManager.CreateAsync(new IdentityUser
            {
                Email = $"{userRegisterDto.UserName}@gmail.com",
                EmailConfirmed = true,
                UserName = userRegisterDto.UserName,
            }, userRegisterDto.Password);

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] UserLoginDto userLoginDto)
        {
            var user = await _userManager.FindByNameAsync(userLoginDto.UserName);
            if (user is null)
                return NotFound($"not found this user : {userLoginDto}");


            return Ok(await _accessControllerService.CreateAccessTokenAsync(user));

        }

        [HttpGet("GetCurrectUser")]
        public IActionResult GetCurrentUser()
            => Ok(_accessControllerService.GetCurrentUser(HttpContext.User.Identity as ClaimsIdentity));

    }
}
