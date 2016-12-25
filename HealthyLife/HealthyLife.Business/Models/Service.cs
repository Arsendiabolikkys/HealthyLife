using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Business.Models
{
    public class Service : IEntity
    {
        public virtual int Id { get; set; }

        public virtual int PatientId { get; set; }

        public virtual int DoctorId { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual string Description { get; set; }

        public virtual decimal Price { get; set; }
    }
}