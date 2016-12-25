using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Business.Models
{
    public class Doctor : IEntity
    {
        public virtual int Id { get; set; }

        public virtual int SpecializationId { get; set; }

        public virtual int AccountId { get; set; }

        public virtual int DepartmentId { get; set; }

        public virtual int ScheduleId { get; set; }
    }
}