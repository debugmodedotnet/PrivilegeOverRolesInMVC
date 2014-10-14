using PrivilegeDemo.Models;
using PrivilegeDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivilegeDemo.Privileges
{
    public class ManageUsersPrivilege : Privilege<ApplicationUser>
    {
        ApplicationUser _user;
        ApplicationDbContext context;
        public ManageUsersPrivilege(ApplicationUser user)
        {
            _user = user;
            context = new ApplicationDbContext();
        }

        public override bool CanManage()
        {
            //Replace Logic to find whether user can manage other user or not 
            var returnedUser = (from r in context.Users where r.Id == _user.Id select r).FirstOrDefault();
            var canManageUserResult = returnedUser.Roles.Select(y => y.RoleId).Contains("1");
            return canManageUserResult;
        }

        public override bool CanAdd()
        {
            //Replace Logic to find whether user can add other user or not 
            return true;
        }

        public override bool CanDelete()
        {
            //Replace Logic to find whether user can delete other user or not 
            return false;
        }

        public override bool CanView()
        {
            //Replace Logic to find whether user can view  other user or not 
            return true;
        }

    }
}