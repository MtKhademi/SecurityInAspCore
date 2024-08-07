﻿using MrMohande3Khademi.DAL.Entities;
using MrMohande3Khademi.Models.User;
using System.Text;
using System.Text.Unicode;

namespace MrMohande3Khademi.Services
{
    public class AccessControllerService : IAccessControllerService
    {
        private readonly UserJWTModel? _currentUser;
        private readonly IHttpContextAccessor _contextAccessor;
        public AccessControllerService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
            var token = _contextAccessor.HttpContext.Request.Headers["TokenAccess"];
            if (!string.IsNullOrWhiteSpace(token))
            {
                try
                {
                    var base64 = Convert.FromBase64String(token);
                    var userJson = Encoding.UTF8.GetString(base64);
                    _currentUser = System.Text.Json.JsonSerializer.Deserialize<UserJWTModel>(userJson);
                }
                catch (Exception ex)
                {
                    //-- LOG
                    _currentUser = null;
                }
            }
        }
        public bool IsAuthenticated => (_currentUser is null || _currentUser is not UserJWTModel)
            ? false : !_currentUser.IsExpier;

        public UserModel? CurrentUser => IsAuthenticated ? _currentUser.User : null;

        public bool IsAuthrozied
        {
            get
            {
                if (!IsAuthenticated)
                    return false;

                if (!_currentUser.User.Roles.Any())
                    return false;

                ///api/Movie -> base api/moviecontroller
                var pathRequest = _contextAccessor.HttpContext.Request.Path.ToString().Replace("api/", "");
                var accessEndPoint = pathRequest.Substring(0, pathRequest.IndexOf("/"));

                if (!_currentUser.User.Roles.Any(r => r.ControllerNames.Contains(accessEndPoint)))
                    return false;

                return true;
            }
        }

        public async Task<string> CreateAccessTokenAsync(UserModel user)
        {
            var jwtUser = new UserJWTModel
            {
                User = user,
                DateTimeLogin = DateTime.Now,
                ExpierMinute = 1
            };

            var userJson = System.Text.Json.JsonSerializer.Serialize(jwtUser);
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(userJson));
        }
    }
}
