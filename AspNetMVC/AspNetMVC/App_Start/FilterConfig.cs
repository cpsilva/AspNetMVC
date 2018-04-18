using AspNetMVC.Filters;
using System.Web.Mvc;

namespace AspNetMVC.App_Start
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(
                new AuthorizationFilterAttribute()
                );
        }
    }
}