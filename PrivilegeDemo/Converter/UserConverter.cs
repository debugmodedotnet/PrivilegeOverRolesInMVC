using PrivilegeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using Microsoft.AspNet.Identity;

namespace PrivilegeDemo.Converter
{
    public static class UserConverter
    {
        public static ApplicationUser ConvertToApplicationUser(string  userId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            ApplicationUser appUser = db.Users.FirstOrDefault(x => x.Id == userId);
            return appUser ;

        }
    }
}