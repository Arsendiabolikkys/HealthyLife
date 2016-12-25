using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface IAddressManager : IManager<Address>
    {
        int Add(Address model);

        void Delete(Address model);

        void Update(Address model);
    }
}
