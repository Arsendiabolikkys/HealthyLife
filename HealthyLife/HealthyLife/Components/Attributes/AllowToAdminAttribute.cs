using HealthyLife.Web.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Components.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AllowToAdminAttribute : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            var request = HttpContext.Current.Request.RequestContext.HttpContext.Request;
            if (!(new WebUserContext().IsAdmin))
            {
                filterContext.Result = new RedirectResult("error/not-found");
            }
        }
    }
}