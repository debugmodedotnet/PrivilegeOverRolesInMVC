using PrivelegeDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.Routing;

namespace PrivelegeDemo.Filters
{
    public class AuthorizationPrivilegeFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            AuthorizationService _authorizeService = new AuthorizationService();
            string userId = HttpContext.Current.User.Identity.GetUserId();
            if (userId != null)
            {
                var result = _authorizeService.CanSeeTheAboutView(userId);
                if (!result)
                {

                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary{{ "controller", "Account" },
                                          { "action", "Login" }

                                         });
                }
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary{{ "controller", "Account" },
                                          { "action", "Login" }

                                         });

            }
            base.OnActionExecuting(filterContext);
        }


        //void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    throw new NotImplementedException();
        //}

        //void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    AuthorizationService _authorizeService = new AuthorizationService();
        //    string userId = HttpContext.Current.User.Identity.GetUserId();
        //    if (userId != null)
        //    {
        //        var result = _authorizeService.CanSeeTheAboutView(userId);
        //        if (!result)
        //        {

        //            filterContext.Result = new RedirectToRouteResult(
        //       new RouteValueDictionary{{ "controller", "Account" },
        //                                  { "action", "Login" }

        //                                 });
        //        }
        //    }
        //    else
        //    {
        //        filterContext.Result = new RedirectToRouteResult(
        //      new RouteValueDictionary{{ "controller", "Account" },
        //                                  { "action", "Login" }

        //                                 });

        //    }
        //}

        //public void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    throw new NotImplementedException();
        //}
    }
}