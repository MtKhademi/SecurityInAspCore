using MrMohande3Khademi.DAL.Entities;
using MrMohande3Khademi.Models.User;

namespace MrMohande3Khademi.Services
{
    public interface IAccessControllerService
    {
        bool IsAuthenticated { get; }
        UserModel? CurrentUser { get; }
        Task<string> CreateAccessTokenAsync(UserModel user);
        bool IsAuthrozied { get; }
    }
}
