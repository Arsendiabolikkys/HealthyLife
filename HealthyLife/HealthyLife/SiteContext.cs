using HealthyLife.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife
{
    public static class SiteContext
    {
        public static ResourceAccessor Texts 
        {
            get 
            {
                return DependencyResolver.Current.GetService<ResourceAccessor>();
            }
        }

        public static IAccountManager Account
        {
            get
            {
                return DependencyResolver.Current.GetService<IAccountManager>();
            }
        }

        public static IAddressManager Address
        {
            get
            {
                return DependencyResolver.Current.GetService<IAddressManager>();
            }
        }

        public static IRoleManager Role
        {
            get
            {
                return DependencyResolver.Current.GetService<IRoleManager>();
            }
        }

        public static IDepartmentManager Department
        {
            get
            {
                return DependencyResolver.Current.GetService<IDepartmentManager>();
            }
        }

        public static IDiseaseManager Disease
        {
            get
            {
                return DependencyResolver.Current.GetService<IDiseaseManager>();
            }
        }

        public static IDoctorManager Doctor
        {
            get
            {
                return DependencyResolver.Current.GetService<IDoctorManager>();
            }
        }

        public static IPatientManager Patient
        {
            get
            {
                return DependencyResolver.Current.GetService<IPatientManager>();
            }
        }

        public static IScheduleManager Schedule
        {
            get
            {
                return DependencyResolver.Current.GetService<IScheduleManager>();
            }
        }

        public static IServiceManager Service
        {
            get
            {
                return DependencyResolver.Current.GetService<IServiceManager>();
            }
        }

        public static ISpecializationManager Specialization
        {
            get
            {
                return DependencyResolver.Current.GetService<ISpecializationManager>();
            }
        }

    }
}