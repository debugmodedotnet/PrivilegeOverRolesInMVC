using PrivilegeDemo.Filters;
using System.Web;
using System.Web.Mvc;

namespace PrivilegeDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
           // filters.Add(new AuthorizationPrivilegeFilter());
        }
    }
}
