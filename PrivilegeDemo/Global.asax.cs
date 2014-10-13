using Microsoft.AspNet.Identity;
using PrivelegeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PrivelegeDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {

        //async Task<bool> AddRoleAndUser()
        //{
        //    AuthenticationIdentityManager IdentityManager = new AuthenticationIdentityManager(
        //        new IdentityStore(new ApplicationDbContext()));

        //    var role = new Role("Role1");
        //    IdentityResult result = await IdentityManager.Roles.CreateRoleAsync(role, CancellationToken.None);
        //    if (result.Success == false)
        //        return false;

        //    var user = new ApplicationUser() { UserName = "user1" };
        //    result = await IdentityManager.Users.CreateLocalUserAsync(user, "Password1");
        //    if (result.Success == false)
        //        return false;

        //    result = await IdentityManager.Roles.AddUserToRoleAsync(user.Id, role.Id, CancellationToken.None);
        //    return result.Success;
        //}
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
    }
}
