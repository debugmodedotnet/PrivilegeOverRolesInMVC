using PrivilegeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivilegeDemo.Privileges
{
    public abstract class Privilege<T>
    {
        public abstract bool CanManage();
        public abstract bool CanAdd();
        public abstract bool CanDelete();
        public abstract bool CanView();
    }
}