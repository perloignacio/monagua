using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
namespace API.Clases
{
    public class AuthorizationFilter : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {

            if (SkipAuthorization(actionContext))
            {
                return true;
            }
            else
            {
                return TokenValidationHandler.ValidaToken(actionContext.Request);
            }

        }

        private static bool SkipAuthorization(HttpActionContext actionContext)
        {

            return actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any()
                       || actionContext.ControllerContext.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any();
        }
    }
}