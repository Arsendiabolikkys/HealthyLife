using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        private AutoMapper.IMapper mapper;

        public DepartmentController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var departments = SiteContext.Department.GetList();
            var model = mapper.Map<List<DepartmentViewModel>>(departments);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var department = SiteContext.Department.GetById(id);
            var model = mapper.Map<DepartmentViewModel>(department);
            ViewBag.Action = "Edit";
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(DepartmentViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var department = mapper.Map<Department>(model);
            SiteContext.Department.Update(department);
            return RedirectToRoute("Admin_Departments");
        }

        public ActionResult Delete(int id)
        {
            var department = SiteContext.Department.GetById(id);
            if (department != null)
                SiteContext.Department.Delete(department);
            return RedirectToRoute("Admin_Departments");
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new DepartmentViewModel();
            ViewBag.Action = "Add";
            return View("Edit", model);
        }

        [HttpPost]
        public ActionResult Add(DepartmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Action = "Add";
                return View("Edit", model);
            }
            var result = mapper.Map<Department>(model);
            SiteContext.Department.Create(result);
            return RedirectToRoute("Admin_Departments");
        }

    }
}
