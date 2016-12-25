using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface IScheduleManager : IManager<Schedule>
    {
        void Delete(Schedule model);

        void Update(Schedule model);
    }
}
