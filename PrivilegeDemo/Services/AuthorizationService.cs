using PrivelegeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivelegeDemo.Services
{
    public class AuthorizationService
    {
        public bool CanSeeTheAboutView(string UserId)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var returnedUser = (from r in context.Users where r.Id == UserId select r).FirstOrDefault();
            var userRoles = returnedUser.Roles.Select(y => y.RoleId).Contains("1");
            if (userRoles)
            {
                return true;
                
            }
            else
            {
                return false;
            }

        }
    }
}