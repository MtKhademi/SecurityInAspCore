namespace Khademi.Models.User
{
    public class UserLoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public override string ToString()
            => $"{UserName} : {Password}";
    }
}
