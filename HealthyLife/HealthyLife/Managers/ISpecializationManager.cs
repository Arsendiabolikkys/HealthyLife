using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface ISpecializationManager : IManager<Specialization>
    {
        void Delete(Specialization model);

        void Update(Specialization model);
    }
}
