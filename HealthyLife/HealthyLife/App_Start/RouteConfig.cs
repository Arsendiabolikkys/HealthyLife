using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HealthyLife
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Logout",
                url: "logout",
                defaults: new { controller = "Account", action = "Logout" },
                namespaces: new[] { "HealthyLife.Controllers" }
            );

            routes.MapRoute(
                name: "RegisterAccount",
                url: "registeraccount/{isDoctor}",
                defaults: new { controller = "Account", action = "RegisterAccount", isDoctor = UrlParameter.Optional },
                namespaces: new[] { "HealthyLife.Controllers" }
            );

            routes.MapRoute(
                name: "Register",
                url: "register",
                defaults: new { controller = "Account", action = "Register" },
                namespaces: new[] { "HealthyLife.Controllers" }
            );

            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Account", action = "Login" },
                namespaces: new[] { "HealthyLife.Controllers" }
            );

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new[] { "HealthyLife.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "HealthyLife.Controllers" }
            );
        }
    }
}