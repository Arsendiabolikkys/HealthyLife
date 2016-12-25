using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class PatientController : Controller
    {
        private AutoMapper.IMapper mapper;

        public PatientController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var patients = SiteContext.Patient.GetList();
            var model = mapper.Map<List<PatientViewModel>>(patients);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var patient = SiteContext.Patient.GetById(id);
            var model = mapper.Map<PatientViewModel>(patient);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(PatientViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var patient = mapper.Map<Patient>(model);
            SiteContext.Patient.Update(patient);
            return RedirectToRoute("Admin_Patients");
        }

        public ActionResult Delete(int id)
        {
            var patient = SiteContext.Patient.GetById(id);
            if (patient != null)
                SiteContext.Patient.Delete(patient);
            return RedirectToRoute("Admin_Patients");
        }

    }
}
