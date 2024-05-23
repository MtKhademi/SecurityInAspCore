using Common;
using Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _001_AuthenticationWays_BuiltIn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(UserLogin user)
        {
            UserModel userModel = GetUser(user);
            if (userModel is not null)
            {
                string token = GenerateToken(userModel);
                return Ok(token);
            }

            return NotFound();
        }

        private string GenerateToken(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["JwtConfig:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            Claim[] claims = new[]
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Email,user.UserName),
                new Claim(ClaimTypes.Role,user.Role),
            };

            var token = new JwtSecurityToken(
                _configuration["JwtConfig:Issuer"],
                _configuration["KwtConfig:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel? GetUser(UserLogin user)
            => DatabaseContext.Users.SingleOrDefault(us => us.Password == user.Password &&
                us.UserName == user.Username);


        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetCurrectUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity is null || !identity.IsAuthenticated)
                return NotFound();

            var user = new UserModel
            {
                UserName = identity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value,
                Role = identity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value
            };
            return Ok(user);
        }
    }
}
