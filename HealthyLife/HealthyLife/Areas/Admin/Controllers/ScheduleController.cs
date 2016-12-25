using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class ScheduleController : Controller
    {
        private AutoMapper.IMapper mapper;

        public ScheduleController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var schedules = SiteContext.Schedule.GetList();
            var model = mapper.Map<List<ScheduleViewModel>>(schedules);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var schedule = SiteContext.Schedule.GetById(id);
            var model = mapper.Map<ScheduleViewModel>(schedule);
            ViewBag.Action = "Edit";
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(ScheduleViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var schedule = mapper.Map<Schedule>(model);
            SiteContext.Schedule.Update(schedule);
            return RedirectToRoute("Admin_Schedules");
        }

        public ActionResult Delete(int id)
        {
            var schedule = SiteContext.Schedule.GetById(id);
            if (schedule != null)
                SiteContext.Schedule.Delete(schedule);
            return RedirectToRoute("Admin_Schedules");
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new ScheduleViewModel();
            ViewBag.Action = "Add";
            return View("Edit", model);
        }

        [HttpPost]
        public ActionResult Add(ScheduleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Action = "Add";
                return View("Edit", model);
            }
            var result = mapper.Map<Schedule>(model);
            SiteContext.Schedule.Create(result);
            return RedirectToRoute("Admin_Schedules");
        }
    }
}
