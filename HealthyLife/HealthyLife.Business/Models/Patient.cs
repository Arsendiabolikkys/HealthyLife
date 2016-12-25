using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Business.Models
{
    public class Patient : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string SocialSecurityNumber { get; set; }

        public virtual int AccountId { get; set; }
    }
}