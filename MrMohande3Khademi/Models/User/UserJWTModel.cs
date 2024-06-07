namespace MrMohande3Khademi.Models.User;

public class UserJWTModel
{
    public UserModel User { get; set; }
    public DateTime DateTimeLogin { get; set; }
    public int ExpierMinute { get; set; }

    public bool IsExpier => DateTime.Now > DateTimeLogin.AddMinutes(ExpierMinute);
}
