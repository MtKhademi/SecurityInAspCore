using Khademi.Configs;
using Khademi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Khademi
{
    public class AccessControllerService(
        IOptions<JWTConfig> _optionConfig) : IAccessControllerService
    {
        public bool IsAuthenticated => throw new NotImplementedException();

        public bool IsAuthrozied => throw new NotImplementedException();

        public async Task<string> CreateAccessTokenAsync(IdentityUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_optionConfig.Value.Key));
            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            Claim[] claims = new[]
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Role,"user")
            };

            var token = new JwtSecurityToken(
                _optionConfig.Value.Issuer,
                _optionConfig.Value.Audience,
                claims,
                null,
                DateTime.Now.AddMinutes(1),
                credential);

            return new JwtSecurityTokenHandler().WriteToken(token);



        }

        public async Task<UserModel> GetCurrentUser(ClaimsIdentity claimsIdentity)
        {
            if (claimsIdentity is null || !claimsIdentity.IsAuthenticated)
                throw new ArgumentException();

            return new UserModel
            {
                UserName = claimsIdentity
                .Claims.SingleOrDefault(us => us.Type == ClaimTypes.Name)
                .Value
            };
        }

    }
}
