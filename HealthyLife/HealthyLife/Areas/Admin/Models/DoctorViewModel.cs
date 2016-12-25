using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Models
{
    public class DoctorViewModel
    {
        public int Id { get; set; }

        public int SpecializationId { get; set; }

        public int AccountId { get; set; }

        public int DepartmentId { get; set; }

        public int ScheduleId { get; set; }

        public SelectList Specializations { get; set; }

        public SelectList Departments { get; set; }

        public SelectList Schedules { get; set; }
    }
}