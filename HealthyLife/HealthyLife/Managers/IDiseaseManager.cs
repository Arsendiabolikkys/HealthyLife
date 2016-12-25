using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface IDiseaseManager : IManager<Disease>
    {
        void Delete(Disease model);

        void Update(Disease model);
    }
}
