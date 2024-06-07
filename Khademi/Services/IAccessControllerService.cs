using Khademi.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Khademi
{
    public interface IAccessControllerService
    {
        bool IsAuthenticated { get; }
        Task<string> CreateAccessTokenAsync(IdentityUser user);
        Task<UserModel> GetCurrentUser(ClaimsIdentity claimsIdentity);
        bool IsAuthrozied { get; }
    }
}
