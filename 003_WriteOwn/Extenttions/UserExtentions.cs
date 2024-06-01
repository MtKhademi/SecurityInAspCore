using _003_WriteOwn.Models.User;

namespace _003_WriteOwn.Extenttions
{
    public static class UserExtentions
    {
        public static UserModel ToUserModel(this UserRegisterDto userRegisterDto)
            => new UserModel
            {
                CreateDateTime = DateTime.Now,
                Password = userRegisterDto.Password,
                UserName = userRegisterDto.UserName
            };
    }
}
