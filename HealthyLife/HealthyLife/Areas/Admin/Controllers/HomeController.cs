using HealthyLife.Components.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    [AllowToAdmin]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

    }
}
