using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace _003_WriteOwn.AUTH
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public async void OnAuthorization(AuthorizationFilterContext context)
        {

            //-- check allow anonymouse
            var AllowAnonymous = context.Filters.SingleOrDefault(x => x.GetType() == 
                typeof(AllowAnonymousUserAttribute));
            if (AllowAnonymous != null)
                return;

            //-- check authenticaiton
            //-- then exist user in header
            var user = context.HttpContext.Items["User"];
            if (user == null)
            {
                context.Result = new UnauthorizedObjectResult(new
                {
                    Message = "You are not authenticated... please call admin"
                });
                return;
            }

            //-- check user access to this endpoint
            

            //var path = context.HttpContext.Request.Path.Value;
            //path = path.Remove(0, path.IndexOf("/") + 1);
            //path = path.Remove(0, path.IndexOf("/") + 1);
            //path = path.Remove(0, path.IndexOf("/") + 1);

            //var existAnyPage = oUser?.Role?.RolePages?.Any(current => current.Page.Address.ToLower()
            //.Contains(path.ToLower())) ?? false;

            //if (!existAnyPage)
            //    context.Result = new JsonResult(ApiResultCreator.UnAuthorization());

        }
    }
}
