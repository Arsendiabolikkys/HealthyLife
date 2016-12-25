using System.Web.Mvc;

namespace HealthyLife.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "Admin_DiseaseAdd",
                url: "admin/disease/add",
                defaults: new { controller = "Disease", action = "Add" }
            );

            context.MapRoute(
                name: "Admin_ScheduleAdd",
                url: "admin/schedule/add",
                defaults: new { controller = "Schedule", action = "Add" }
            );

            context.MapRoute(
                name: "Admin_DepartmentAdd",
                url: "admin/department/add",
                defaults: new { controller = "Department", action = "Add" }
            );

            context.MapRoute(
                name: "Admin_SpecializationAdd",
                url: "admin/specialization/add",
                defaults: new { controller = "Specialization", action = "Add" }
            );

            context.MapRoute(
                name: "Admin_SpecializationEdit",
                url: "admin/specialization/edit/{id}",
                defaults: new { controller = "Specialization", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_SpecializationDelete",
                url: "admin/specialization/delete/{id}",
                defaults: new { controller = "Specialization", action = "Delete", id = UrlParameter.Optional }
            );
            
            context.MapRoute(
                name: "Admin_ServiceEdit",
                url: "admin/service/edit/{id}",
                defaults: new { controller = "Service", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_ServiceDelete",
                url: "admin/service/delete/{id}",
                defaults: new { controller = "Service", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_ScheduleEdit",
                url: "admin/schedule/edit/{id}",
                defaults: new { controller = "Schedule", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_ScheduleDelete",
                url: "admin/schedule/delete/{id}",
                defaults: new { controller = "Schedule", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_PatientEdit",
                url: "admin/patient/edit/{id}",
                defaults: new { controller = "Patient", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_PatientDelete",
                url: "admin/patient/delete/{id}",
                defaults: new { controller = "Patient", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_DoctorEdit",
                url: "admin/doctor/edit/{id}",
                defaults: new { controller = "Doctor", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_DoctorDelete",
                url: "admin/doctor/delete/{id}",
                defaults: new { controller = "Doctor", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_DiseaseEdit",
                url: "admin/disease/edit/{id}",
                defaults: new { controller = "Disease", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_DiseaseDelete",
                url: "admin/disease/delete/{id}",
                defaults: new { controller = "Disease", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_DepartmentEdit",
                url: "admin/department/edit/{id}",
                defaults: new { controller = "Department", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_DepartmentDelete",
                url: "admin/department/delete/{id}",
                defaults: new { controller = "Department", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_AddressEdit",
                url: "admin/address/edit/{id}",
                defaults: new { controller = "Address", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_AddressDelete",
                url: "admin/address/delete/{id}",
                defaults: new { controller = "Address", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_AccountEdit",
                url: "admin/account/edit/{id}",
                defaults: new { controller = "Account", action = "Edit", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_AccountDelete",
                url: "admin/account/delete/{id}",
                defaults: new { controller = "Account", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                name: "Admin_Specializations",
                url: "admin/specializations",
                defaults: new { controller = "Specialization", action = "Index" }
            );

            context.MapRoute(
                name: "Admin_Services",
                url: "admin/services",
                defaults: new { controller = "Service", action = "Index" }
            );

            context.MapRoute(
                name: "Admin_Schedules",
                url: "admin/schedules",
                defaults: new { controller = "Schedule", action = "Index" }
            );

            context.MapRoute(
                name: "Admin_Patients",
                url: "admin/patients",
                defaults: new { controller = "Patient", action = "Index" }
            );

            context.MapRoute(
                name: "Admin_Doctors",
                url: "admin/doctors",
                defaults: new { controller = "Doctor", action = "Index" }
            );

            context.MapRoute(
                name: "Admin_Diseases",
                url: "admin/diseases",
                defaults: new { controller = "Disease", action = "Index" }
            );

            context.MapRoute(
                name: "Admin_Departments",
                url: "admin/departments",
                defaults: new { controller = "Department", action = "Index" }
            );

            context.MapRoute(
                name: "Admin_Addresses",
                url: "admin/addresses",
                defaults: new { controller = "Address", action = "Index"}
            );

            context.MapRoute(
                name: "Admin_Accounts",
                url: "admin/accounts",
                defaults: new { controller = "Account", action = "Index"}
            );

            context.MapRoute(
                name: "Admin_Home",
                url: "admin",
                defaults: new { controller = "Home", action = "Index" }
            );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
