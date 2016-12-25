using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLife.Models
{
    public class AddressViewModel
    {
        [DisplayName(Constants.Address.Country)]
        public string Country { get; set; }

        [DisplayName(Constants.Address.City)]
        public string City { get; set; }

        [DisplayName(Constants.Address.TelNumber)]
        public string TelNumber { get; set; }

        [DisplayName(Constants.Address.Description)]
        public string Description { get; set; }
    }
}