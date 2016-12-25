using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface IPatientManager : IManager<Patient>
    {
        void Delete(Patient model);

        void Update(Patient model);
    }
}
