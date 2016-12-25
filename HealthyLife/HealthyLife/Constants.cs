using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife
{
    public class Constants
    {
        public class Main
        {
            public const string HealthyLife = "HealthyLife";
            public const string Edit = "Edit";
            public const string Delete = "Delete";
            public const string Add = "Add";
            public const string Id = "Id";
            public const string RegisterAsPatient = "RegisterAsPatient";
            public const string RegisterAsDoctor = "RegisterAsDoctor";
        }

        public class Department
        {
            public const string Name = "Department_Name";
        }

        public class Specialization
        {
            public const string Name = "Specialization_Name";
            public const string Description = "Specialization_Description";
        }

        public class Patient
        {
            public const string SocialSecurityNumber = "SocialSecurityNumber";
        }

        public class Disease
        {
            public const string Name = "Disease_Name";
            public const string Description = "Disease_Description";
        }

        public class Doctor
        {
            public const string Schedule = "Doctor_Schedule";
            public const string Specialization = "Doctor_Specialization";
            public const string Department = "Doctor_Department";
        }

        public class Account
        {
            public const string Password = "Password";
            public const string ConfirmPassword = "ConfirmPassword";
            public const string Email = "Email";
            public const string Name = "Name";
            public const string SecondName = "SecondName";
            public const string DateOfBirth = "DateOfBirth";
            public const string Photo = "Photo";
            public const string AddressId = "AddressId";
            public const string RoleId = "RoleId";
        }

        public class Fields
        {
            public const string Name = "Name";
        }

        public class Address
        {
            public const string Country = "Country";
            public const string City = "City";
            public const string TelNumber = "TelNumber";
            public const string Description = "Address_Description";
        }

        public class Role
        {
            public const string Name = "Name";
            public const string Patient = "Patient";
            public const string Doctor = "Doctor";
            public const string Admin = "Admin";
        }

        public class Schedule
        {
            public const string Day = "Day";
            public const string From = "From";
            public const string To = "To";
        }

        public class Service
        {
            public const string Patient = "Service_Patient";
            public const string Doctor = "Service_Doctor";
            public const string Date = "Service_Date";
            public const string Description = "Service_Description";
            public const string Price = "Service_Price";
        }

        public class Admin
        {
            public const string Admin_Accounts = "Admin_Accounts";
            public const string Admin_Addresses = "Admin_Addresses";
            public const string Admin_Departments = "Admin_Departments";
            public const string Admin_Diseases = "Admin_Diseases";
            public const string Admin_Doctors = "Admin_Doctors";
            public const string Admin_Patients = "Admin_Patients";
            public const string Admin_Schedules = "Admin_Schedules";
            public const string Admin_Services = "Admin_Services";
            public const string Admin_Specializations = "Admin_Specializations";
        }
    }
}