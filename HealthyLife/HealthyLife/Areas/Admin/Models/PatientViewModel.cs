using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Areas.Admin.Models
{
    public class PatientViewModel
    {
        public int Id { get; set; }

        public string SocialSecurityNumber { get; set; }

        public int AccountId { get; set; }
    }
}