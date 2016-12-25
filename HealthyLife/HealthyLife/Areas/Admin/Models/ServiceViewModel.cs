using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Models
{
    public class ServiceViewModel
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        [UIHint("DateTime")]
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public SelectList Patients { get; set; }

        public SelectList Doctors { get; set; }
    }
}