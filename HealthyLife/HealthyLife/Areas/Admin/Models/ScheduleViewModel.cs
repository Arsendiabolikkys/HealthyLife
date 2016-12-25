using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Areas.Admin.Models
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }

        public string Day { get; set; }

        public string FromValue { get; set; }

        public string ToValue { get; set; }
    }
}