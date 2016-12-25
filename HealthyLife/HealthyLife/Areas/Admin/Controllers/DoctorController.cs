using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class DoctorController : Controller
    {
        private AutoMapper.IMapper mapper;

        public DoctorController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var doctors = SiteContext.Doctor.GetList();
            var model = mapper.Map<List<DoctorViewModel>>(doctors);
            if (model.Any())
            {
                var departments = SiteContext.Department.GetList();
                var schedules = SiteContext.Schedule.GetList();
                var specializations = SiteContext.Specialization.GetList();
                model.FirstOrDefault().Departments = new SelectList(departments, Constants.Main.Id, Constants.Fields.Name);
                model.FirstOrDefault().Schedules = new SelectList(schedules, Constants.Main.Id, Constants.Main.Id);
                model.FirstOrDefault().Specializations = new SelectList(specializations, Constants.Main.Id, Constants.Fields.Name);
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var doctor = SiteContext.Doctor.GetById(id);
            var model = mapper.Map<DoctorViewModel>(doctor);
            var departments = SiteContext.Department.GetList();
            var schedules = SiteContext.Schedule.GetList();
            var specializations = SiteContext.Specialization.GetList();
            model.Departments = new SelectList(departments, Constants.Main.Id, Constants.Fields.Name);
            model.Schedules = new SelectList(schedules, Constants.Main.Id, Constants.Main.Id);
            model.Specializations = new SelectList(specializations, Constants.Main.Id, Constants.Fields.Name);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(DoctorViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var doctor = mapper.Map<Doctor>(model);
            SiteContext.Doctor.Update(doctor);
            return RedirectToRoute("Admin_Doctors");
        }

        public ActionResult Delete(int id)
        {
            var disease = SiteContext.Disease.GetById(id);
            if (disease != null)
                SiteContext.Disease.Delete(disease);
            return RedirectToRoute("Admin_Doctors");
        }

    }
}
