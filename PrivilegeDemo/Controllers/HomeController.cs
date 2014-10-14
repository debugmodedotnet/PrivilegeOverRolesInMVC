using PrivilegeDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using PrivilegeDemo.Filters;
using PrivilegeDemo.Privileges;
using PrivilegeDemo.Converter;
using PrivilegeDemo.Models;


namespace PrivilegeDemo.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       //  [AuthorizationPrivilegeFilter]

        
        public ActionResult About()
        {

            string userId = User.Identity.GetUserId();
            if (userId != null)
            {
                ApplicationUser appUser = UserConverter.ConvertToApplicationUser(userId);
                var manageUserPrivilege = new ManageUsersPrivilege(appUser);
                if (manageUserPrivilege.CanManage())
                {
                    ViewBag.Message = "Your application description page.";
                    return View();
                }
                else
                {
                   return   RedirectToAction("Login", "Account");
                   
                    
                }
            }
            else
            {
                 return RedirectToAction("Login", "Account");
            }
         
        }
    
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }



       
    }
}