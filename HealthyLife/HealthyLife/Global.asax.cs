using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Integration.Mvc;
using Autofac.Builder;
using HealthyLife.Web.User;
using HealthyLife.Managers;
using HealthyLife.Models;
using HealthyLife.Business.Models;

namespace HealthyLife
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            InitializeFramework();
        }

        protected void InitializeFramework()
        {
            RegisterDependencies();
        }

        protected void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            builder.RegisterType<AccountManager>();
            builder.RegisterType<AccountManager>().As<IAccountManager>();
            builder.RegisterType<AddressManager>();
            builder.RegisterType<AddressManager>().As<IAddressManager>();
            builder.RegisterType<RoleManager>();
            builder.RegisterType<RoleManager>().As<IRoleManager>();
            builder.RegisterType<DepartmentManager>();
            builder.RegisterType<DepartmentManager>().As<IDepartmentManager>();
            builder.RegisterType<DiseaseManager>();
            builder.RegisterType<DiseaseManager>().As<IDiseaseManager>();
            builder.RegisterType<DoctorManager>();
            builder.RegisterType<DoctorManager>().As<IDoctorManager>();
            builder.RegisterType<PatientManager>();
            builder.RegisterType<PatientManager>().As<IPatientManager>();
            builder.RegisterType<ScheduleManager>();
            builder.RegisterType<ScheduleManager>().As<IScheduleManager>();
            builder.RegisterType<ServiceManager>();
            builder.RegisterType<ServiceManager>().As<IServiceManager>();
            builder.RegisterType<SpecializationManager>();
            builder.RegisterType<SpecializationManager>().As<ISpecializationManager>();

            builder.RegisterInstance<AutoMapper.IMapper>(GetMapper());
            builder.RegisterType<WebUserContext>().As<WebUserContext>().InstancePerHttpRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        protected IMapper GetMapper()
        {
            return new AutoMapper.MapperConfiguration(x =>
            {
                x.CreateMap<Account, AccountViewModel>();
                x.CreateMap<AccountViewModel, Account>();

                x.CreateMap<Address, AddressViewModel>();
                x.CreateMap<AddressViewModel, Address>();

                x.CreateMap<Doctor, DoctorViewModel>();
                x.CreateMap<DoctorViewModel, Doctor>();

                x.CreateMap<Patient, PatientViewModel>();
                x.CreateMap<PatientViewModel, Patient>();

                x.CreateMap<Department, DepartmentViewModel>();
                x.CreateMap<DepartmentViewModel, Department>();

                x.CreateMap<Specialization, SpecializationViewModel>();
                x.CreateMap<SpecializationViewModel, Specialization>();

                //ADMIN AREA REGISTRATION
                x.CreateMap<Account, Areas.Admin.Models.AccountViewModel>();
                x.CreateMap<Areas.Admin.Models.AccountViewModel, Account>();
                x.CreateMap<Address, Areas.Admin.Models.AddressViewModel>();
                x.CreateMap<Areas.Admin.Models.AddressViewModel, Address>();
                x.CreateMap<Department, Areas.Admin.Models.DepartmentViewModel>();
                x.CreateMap<Areas.Admin.Models.DepartmentViewModel, Department>();
                x.CreateMap<Disease, Areas.Admin.Models.DiseaseViewModel>();
                x.CreateMap<Areas.Admin.Models.DiseaseViewModel, Disease>();
                x.CreateMap<Doctor, Areas.Admin.Models.DoctorViewModel>();
                x.CreateMap<Areas.Admin.Models.DoctorViewModel, Doctor>();
                x.CreateMap<Patient, Areas.Admin.Models.PatientViewModel>();
                x.CreateMap<Areas.Admin.Models.PatientViewModel, Patient>();
                x.CreateMap<Schedule, Areas.Admin.Models.ScheduleViewModel>();
                x.CreateMap<Areas.Admin.Models.ScheduleViewModel, Schedule>();
                x.CreateMap<Service, Areas.Admin.Models.ServiceViewModel>();
                x.CreateMap<Areas.Admin.Models.ServiceViewModel, Service>();
                x.CreateMap<Specialization, Areas.Admin.Models.SpecializationViewModel>();
                x.CreateMap<Areas.Admin.Models.SpecializationViewModel, Specialization>();

            }).CreateMapper();
        }
    }
}