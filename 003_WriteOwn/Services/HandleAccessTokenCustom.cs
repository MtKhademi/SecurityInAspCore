using _003_WriteOwn.Models.User;
using System.Collections;
using System.Linq;
using System.Text;

namespace _003_WriteOwn.Services
{
    public class HandleAccessTokenCustom : IHandleAccessToken<UserModel>
    {
        public string GetAccessToken(UserModel model)
        {
            var userJson = System.Text.Json.JsonSerializer.Serialize(model);
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(userJson));
        }

        public UserModel GetModelFromAccessToken(string accessToken)
        {
            var userJson = Convert.FromBase64String(accessToken);
            var x = Encoding.UTF8.GetString(userJson);
            return System.Text.Json.JsonSerializer.Deserialize<UserModel>(x);
        }
    }
}
