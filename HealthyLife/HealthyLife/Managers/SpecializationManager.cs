using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class SpecializationManager : ISpecializationManager
    {
        public SpecializationDataProvider provider = new SpecializationDataProvider();

        public void Delete(Business.Models.Specialization model)
        {
            provider.Delete(model);
        }

        public void Update(Business.Models.Specialization model)
        {
            provider.Update(model);
        }

        public Business.Models.Specialization GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Business.Models.Specialization model)
        {
            provider.Create(model);
        }

        public IList<Business.Models.Specialization> GetList()
        {
            return provider.GetList();
        }
    }
}