using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Areas.Admin.Models
{
    public class AccountViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        public int AddressId { get; set; }

        public int RoleId { get; set; }

        public SelectList Addresses { get; set; }

        public SelectList Roles { get; set; }
    }
}