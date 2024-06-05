using MrMohande3Khademi.DAL.Entities;
using MrMohande3Khademi.Models.Role;

namespace MrMohande3Khademi.Extenttions
{
    public static class RoleExtentions
    {
        public static RoleModel ToRoleModel(this RoleEntity roleEntity)
            => new RoleModel
            {
                RoleName = roleEntity.Name,
                ControllerNames = roleEntity.ControllerAccess.Split(';').ToList()
            };
    }
}
