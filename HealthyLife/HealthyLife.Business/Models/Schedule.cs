using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Business.Models
{
    public class Schedule : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Day { get; set; }

        public virtual string FromValue { get; set; }

        public virtual string ToValue { get; set; }
    }
}
