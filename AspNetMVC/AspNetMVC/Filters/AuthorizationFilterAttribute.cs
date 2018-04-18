using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;
using System.Linq;
using System;

namespace AspNetMVC.Filters
{
    public class AuthorizationFilterAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            // Liberar acesso anonimo
            bool allowAnonymous = filterContext.ActionDescriptor.GetCustomAttributes(typeof(AllowAnonymousAttribute), true).Any()
                || filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(typeof(AllowAnonymousAttribute), true).Any();

            if (allowAnonymous) return;

            var usuario = filterContext.HttpContext.Session["usuarioAutenticado"];

            if (usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Index" }
                        )
                    );
            }
        }
    }
}