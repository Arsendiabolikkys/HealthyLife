using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class SpecializationController : Controller
    {
        private AutoMapper.IMapper mapper;

        public SpecializationController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var specializations = SiteContext.Specialization.GetList();
            var model = mapper.Map<List<SpecializationViewModel>>(specializations);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var specialization = SiteContext.Specialization.GetById(id);
            var model = mapper.Map<SpecializationViewModel>(specialization);
            ViewBag.Action = "Edit";
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(SpecializationViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var specialization = mapper.Map<Specialization>(model);
            SiteContext.Specialization.Update(specialization);
            return RedirectToRoute("Admin_Specializations");
        }

        public ActionResult Delete(int id)
        {
            var specialization = SiteContext.Specialization.GetById(id);
            if (specialization != null)
                SiteContext.Specialization.Delete(specialization);
            return RedirectToRoute("Admin_Specializations");
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new SpecializationViewModel();
            ViewBag.Action = "Add";
            return View("Edit", model);
        }

        [HttpPost]
        public ActionResult Add(SpecializationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Action = "Add";
                return View("Edit", model);
            }
            var result = mapper.Map<Specialization>(model);
            SiteContext.Specialization.Create(result);
            return RedirectToRoute("Admin_Specializations");
        }

    }
}
