using MrMohande3Khademi.DAL.Entities;
using MrMohande3Khademi.Models.User;

namespace MrMohande3Khademi.Extenttions
{
    public static class UserExtentions
    {
        public static UserEntity ToUserEntity(this UserRegisterDto userRegisterDto)
            => new UserEntity
            {
                CreateDateTime = DateTime.Now,
                Password = userRegisterDto.Password,
                UserName = userRegisterDto.UserName
            };

        public static UserModel ToUserModel(this UserEntity userEntity)
            => new UserModel
            {
                //Roles = userEntity.Roles.Select(ur => ur.Role).Select(x => x.ToRoleModel()).ToList(),
                UserName = userEntity.UserName,
            };



    }
}
