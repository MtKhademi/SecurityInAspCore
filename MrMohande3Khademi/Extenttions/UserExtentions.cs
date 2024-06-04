using MrMohande3Khademi.DAL.Entities;
using MrMohande3Khademi.Models.User;

namespace MrMohande3Khademi.Extenttions
{
    public static class UserExtentions
    {
        public static UserEntity ToUserModel(this UserRegisterDto userRegisterDto)
            => new UserEntity
            {
                CreateDateTime = DateTime.Now,
                Password = userRegisterDto.Password,
                UserName = userRegisterDto.UserName
            };
    }
}
