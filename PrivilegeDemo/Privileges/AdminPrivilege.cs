using Microsoft.AspNet.Identity.EntityFramework;
using PrivilegeDemo.Models;
using PrivilegeDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivilegeDemo.Privileges
{
    //public class AdminPrivilege 
    //{

    //    public override bool CanManageUsers(string  Userid)
    //    {
    //        AuthorizationService authorizeService = new AuthorizationService();

    //        var canManageUserResult = authorizeService.CanManageUser(Userid);
    //        return canManageUserResult;

           
    //    }

    //    public override bool CanManageRoles(string Userid)
    //    {
    //        AuthorizationService authorizeService = new AuthorizationService();           
    //        var canManageUserResult = authorizeService.CanManageUser(Userid);
    //        return canManageUserResult;
    //    }
    //}
}