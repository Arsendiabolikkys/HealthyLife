using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class ServiceManager : IServiceManager
    {
        public ServiceDataProvider provider = new ServiceDataProvider();

        public void Delete(Business.Models.Service model)
        {
            provider.Delete(model);
        }

        public void Update(Business.Models.Service model)
        {
            provider.Update(model);
        }

        public Business.Models.Service GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Business.Models.Service model)
        {
            provider.Create(model);
        }

        public IList<Business.Models.Service> GetList()
        {
            return provider.GetList();
        }
    }
}