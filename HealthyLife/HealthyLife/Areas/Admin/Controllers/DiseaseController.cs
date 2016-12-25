using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class DiseaseController : Controller
    {
        private AutoMapper.IMapper mapper;

        public DiseaseController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var diseases = SiteContext.Disease.GetList();
            var model = mapper.Map<List<DiseaseViewModel>>(diseases);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var disease = SiteContext.Disease.GetById(id);
            var model = mapper.Map<DiseaseViewModel>(disease);
            ViewBag.Action = "Edit";
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(DiseaseViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var disease = mapper.Map<Disease>(model);
            SiteContext.Disease.Update(disease);
            return RedirectToRoute("Admin_Diseases");
        }

        public ActionResult Delete(int id)
        {
            var disease = SiteContext.Disease.GetById(id);
            if (disease != null)
                SiteContext.Disease.Delete(disease);
            return RedirectToRoute("Admin_Diseases");
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new DiseaseViewModel();
            ViewBag.Action = "Add";
            return View("Edit", model);
        }

        [HttpPost]
        public ActionResult Add(DiseaseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Action = "Add";
                return View("Edit", model);
            }
            var result = mapper.Map<Disease>(model);
            SiteContext.Disease.Create(result);
            return RedirectToRoute("Admin_Diseases");
        }
    }
}
