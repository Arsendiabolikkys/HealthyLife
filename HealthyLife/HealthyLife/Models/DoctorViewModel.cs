using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Models
{
    public class DoctorViewModel
    {
        public int Id { get; set; }

        [Required]
        public int SpecializationId { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public int ScheduleId { get; set; }

        public SelectList Specializations { get; set; }

        public SelectList Departments { get; set; }

        public SelectList Schedules { get; set; }
    }
}