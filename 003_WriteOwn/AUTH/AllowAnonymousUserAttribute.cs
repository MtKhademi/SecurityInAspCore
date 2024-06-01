using Microsoft.AspNetCore.Mvc.Filters;

namespace _003_WriteOwn.AUTH
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class AllowAnonymousUserAttribute : Attribute, IAuthorizationFilter
    {
        public async void OnAuthorization(AuthorizationFilterContext context)
        {
        }
    }
}
