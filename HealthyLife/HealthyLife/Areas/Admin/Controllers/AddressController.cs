using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class AddressController : Controller
    {
        private AutoMapper.IMapper mapper;

        public AddressController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var addresses = SiteContext.Address.GetList();
            var model = mapper.Map<List<AddressViewModel>>(addresses);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var address = SiteContext.Address.GetById(id);
            var model = mapper.Map<AddressViewModel>(address);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(AddressViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var address = mapper.Map<Address>(model);
            SiteContext.Address.Update(address);
            return RedirectToRoute("Admin_Addresses");
        }

        public ActionResult Delete(int id)
        {
            var address = SiteContext.Address.GetById(id);
            if (address != null)
                SiteContext.Address.Delete(address);
            return RedirectToRoute("Admin_Addresses");
        }
    }
}
