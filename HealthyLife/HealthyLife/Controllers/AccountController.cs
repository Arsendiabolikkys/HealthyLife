using HealthyLife.Business.Models;
using HealthyLife.Managers;
using HealthyLife.Models;
using HealthyLife.Web.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HealthyLife.Controllers
{
    public class AccountController : Controller
    {
        private WebUserContext userContext;
        private AutoMapper.IMapper mapper;

        public AccountController()
        {
            mapper = DependencyResolver.Current.GetService<AutoMapper.IMapper>();
            userContext = new WebUserContext();
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (userContext.IsLoggedIn)
                return RedirectToRoute("Home");

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(AccountLoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (SiteContext.Account.IsPasswordValid(model.Email, model.Password) == true)
            {
                FormsAuthentication.SetAuthCookie(model.Email, false);
                return RedirectToRoute("Home");
            }
            ModelState.AddModelError("", "Невірний e-mail або пароль");
            return View(model);
        }

        [HttpGet]
        public ActionResult Register()
        {
            if (userContext.IsLoggedIn)
                return RedirectToRoute("Home");

            return View(new AccountViewModel());
        }

        [HttpGet]
        public ActionResult RegisterAccount(int isDoctor)
        {
            var model = new AccountViewModel();
            model.IsDoctor = isDoctor == 1;
            if (model.IsDoctor)
            {
                model.Doctor = CreateDoctorModel();
            }
            else
                model.Patient = new PatientViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult RegisterAccount(AccountViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (!Register(model))
            {
                model.Doctor = CreateDoctorModel();
                model.Patient = new PatientViewModel();
                ModelState.AddModelError("", "Користувач з такою електронною адресою вже існує");
                return View(model);
            }
            return RedirectToRoute("Home");
        }

        public ActionResult Logout()
        {
            if (userContext.IsLoggedIn)
                FormsAuthentication.SignOut();

            return RedirectToRoute("Home");
        }

        protected DoctorViewModel CreateDoctorModel()
        {
            var result = new DoctorViewModel();
            var departments = SiteContext.Department.GetList();
            var schedules = SiteContext.Schedule.GetList();
            var specializations = SiteContext.Specialization.GetList();
            result.Departments = new SelectList(departments, Constants.Main.Id, Constants.Fields.Name);
            result.Schedules = new SelectList(schedules, Constants.Main.Id, Constants.Main.Id);
            result.Specializations = new SelectList(specializations, Constants.Main.Id, Constants.Fields.Name);
            return result;
        }

        protected bool Register(AccountViewModel model)
        {
            var userExist = SiteContext.Account.GetByEmail(model.Email);
            if (userExist == null)
            {
                var mappedUser = mapper.Map<Account>(model);
                var address = mapper.Map<Address>(model.Address);
                mappedUser.AddressId = SiteContext.Address.Add(address);
                mappedUser.RoleId = model.IsDoctor ? SiteContext.Role.GetByName(Constants.Role.Doctor).Id 
                                             : SiteContext.Role.GetByName(Constants.Role.Patient).Id;
                var accountId = SiteContext.Account.Add(mappedUser);
                if (model.IsDoctor)
                {
                    var doctor = mapper.Map<Doctor>(model.Doctor);
                    doctor.AccountId = accountId;
                    SiteContext.Doctor.Create(doctor);
                }
                else
                {
                    var patient = mapper.Map<Patient>(model.Patient);
                    patient.AccountId = accountId;
                    SiteContext.Patient.Create(patient);
                }
                FormsAuthentication.SetAuthCookie(model.Email, false);
            }
            else
            {
                ModelState.AddModelError("", "Користувач з такою електронною адресою вже існує");
                return false;
            }
            return true;
        }
    }
}
