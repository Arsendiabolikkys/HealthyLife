using HealthyLife.Areas.Admin.Models;
using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private AutoMapper.IMapper mapper;

        public AccountController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
        }

        public ActionResult Index()
        {
            var accounts = SiteContext.Account.GetList();
            var model = mapper.Map<List<AccountViewModel>>(accounts);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var account = SiteContext.Account.GetById(id);
            var model = mapper.Map<AccountViewModel>(account);
            var addresses = SiteContext.Address.GetList();
            var roles = SiteContext.Role.GetList();
            model.Addresses = new SelectList(addresses, Constants.Main.Id, Constants.Main.Id);
            model.Roles = new SelectList(roles, Constants.Main.Id, Constants.Role.Name);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(AccountViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var account = SiteContext.Account.GetById(model.Id);
            UpdateFields(account, model);
            SiteContext.Account.Update(account);
            return RedirectToRoute("Admin_Accounts");
        }

        public ActionResult Delete(int id)
        {
            var account = SiteContext.Account.GetById(id);
            if (account != null)
                SiteContext.Account.Delete(account);
            return RedirectToRoute("Admin_Accounts");
        }

        private void UpdateFields(Account account, AccountViewModel model)
        {
            account.RoleId = model.RoleId;
            account.AddressId = model.AddressId;
        }
    }
}
