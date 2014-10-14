using PrivilegeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivilegeDemo.Services
{
    public class AuthorizationService
    {
        public bool CanManageUser(string UserId)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var returnedUser = (from r in context.Users where r.Id == UserId select r).FirstOrDefault();
            var canManageUserResult = returnedUser.Roles.Select(y => y.RoleId).Contains("1");
            return canManageUserResult;

        }
        public bool CanManageRoles(string UserId)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var returnedUser = (from r in context.Users where r.Id == UserId select r).FirstOrDefault();
            var canManageUserResult = returnedUser.Roles.Select(y => y.RoleId).Contains("1");
            return canManageUserResult;

        }
    }
}