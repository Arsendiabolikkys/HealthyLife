using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface IServiceManager : IManager<Service>
    {
        void Delete(Service model);

        void Update(Service model);
    }
}
