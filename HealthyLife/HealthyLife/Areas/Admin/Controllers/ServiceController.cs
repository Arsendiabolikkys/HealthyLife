using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        private AutoMapper.IMapper mapper;

        public ServiceController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var services = SiteContext.Service.GetList();
            var model = mapper.Map<List<ServiceViewModel>>(services);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var service = SiteContext.Service.GetById(id);
            var model = mapper.Map<ServiceViewModel>(service);
            var patients = SiteContext.Patient.GetList();
            var doctors = SiteContext.Doctor.GetList();
            model.Patients = new SelectList(patients, Constants.Main.Id, Constants.Patient.SocialSecurityNumber);
            model.Doctors = new SelectList(doctors, Constants.Main.Id, Constants.Main.Id);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(ServiceViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var service = mapper.Map<Service>(model);
            SiteContext.Service.Update(service);
            return RedirectToRoute("Admin_Services");
        }

        public ActionResult Delete(int id)
        {
            var service = SiteContext.Service.GetById(id);
            if (service != null)
                SiteContext.Service.Delete(service);
            return RedirectToRoute("Admin_Services");
        }
    }
}
