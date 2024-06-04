using MrMohande3Khademi.DAL.Entities;

namespace MrMohande3Khademi.Services
{
    public class AccessControllerService : IAccessControllerService
    {
        public bool IsAuthenticated => true;

        public UserEntity CurrentUser => new UserEntity();

        public async Task<string> CreateAccessTokenAsync(UserEntity user)
        {
            return "";
        }
    }
}
