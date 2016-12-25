using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Business.Models
{
    public class Address : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Country { get; set; }

        public virtual string City { get; set; }

        public virtual string TelNumber { get; set; }

        public virtual string Description { get; set; }
    }
}