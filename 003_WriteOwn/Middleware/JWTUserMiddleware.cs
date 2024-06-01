using _003_WriteOwn.Models.User;
using _003_WriteOwn.Services;

namespace _003_WriteOwn.Middleware
{

    public static class ExtentionsApplicationBuilder
    {

        public static IApplicationBuilder UseJWTUserHandlerToken(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<JWTUserMiddleware>();
        }

    }

    public class JWTUserMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<JWTUserMiddleware> _logger;

        public JWTUserMiddleware(RequestDelegate next, ILogger<JWTUserMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }


        public async Task Invoke(HttpContext context, IHandleAccessToken<UserModel> jWTHandlerService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (token != null)
                attachUserToContext(context, jWTHandlerService, token);
            else
                _logger.LogError($"Not exist anu TOKEN in header request");
            await _next(context);
        }

        private void attachUserToContext(HttpContext context, IHandleAccessToken<UserModel> jWTHandlerService, string token)
        {
            try
            {
                var account = jWTHandlerService.GetModelFromAccessToken(token);
                // attach user to context on successful jwt validation
                if (string.IsNullOrWhiteSpace(account?.UserName))
                    context.Items["User"] = null;
                else
                    context.Items["User"] = account;
            }
            catch (Exception ex)
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
                _logger.LogError($"Can not get user from OAK :: {ex}");
            }
        }

    }
}
