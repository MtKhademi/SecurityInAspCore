using MrMohande3Khademi.Models.Role;

namespace MrMohande3Khademi.Models.User
{
    public class UserModel
    {
        public string UserName { get; set; } = null!;
        public List<RoleModel> Roles { get; set; } = [];
    }


}
