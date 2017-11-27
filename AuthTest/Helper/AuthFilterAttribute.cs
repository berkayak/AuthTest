using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthTest.Helper
{
    public class AuthFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var test = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            if (filterContext.HttpContext.Session["admin"] != null && filterContext.HttpContext.Session["admin"].ToString() == "berkay")
            {
                
            }
            else
            {                
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(){{ "controller", "Home" }, { "action", "Login"}});
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }
    }
}