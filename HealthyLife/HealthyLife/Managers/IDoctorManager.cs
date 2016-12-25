using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface IDoctorManager : IManager<Doctor>
    {
        void Delete(Doctor model);

        void Update(Doctor model);
    }
}
