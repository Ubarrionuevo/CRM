using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebadmiClient.Filters
{


    //public class AutenticacionRequeridaAttribute : ActionFilterAttribute
    //{
    //    public override void OnActionExecuting(ActionExecutingContext filterContext)
    //    {
    //        if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
    //        {
    //            var descriptor = filterContext.ActionDescriptor;
    //            var isLoginAction = descriptor.ControllerDescriptor.ControllerName.Equals("Login", StringComparison.OrdinalIgnoreCase) &&
    //                                descriptor.ActionName.Equals("Login", StringComparison.OrdinalIgnoreCase);

    //            if (!isLoginAction)
    //            {
    //                filterContext.Result = new RedirectResult("~/Login/Login");
    //            }
    //        }
    //    }
    //}

}