using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Areas.Admin.Models
{
    public class AddressViewModel
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string TelNumber { get; set; }

        public string Description { get; set; }
    }
}