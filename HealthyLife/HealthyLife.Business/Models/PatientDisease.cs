using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Business.Models
{
    public class PatientDisease : IEntity
    {
        public virtual int Id { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime EndDate { get; set; }

        public virtual int DiseaseId { get; set; }

        public virtual int PatientId { get; set; }

        public virtual string Description { get; set; }

        public virtual int ConditionId { get; set; }
    }
}