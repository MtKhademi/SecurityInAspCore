using MrMohande3Khademi.DAL.Entities;

namespace MrMohande3Khademi.Services
{
    public interface IAccessControllerService
    {
        bool IsAuthenticated { get; }
        UserEntity CurrentUser { get; }
        Task<string> CreateAccessTokenAsync(UserEntity user);
    }
}
