using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class DoctorManager : IDoctorManager
    {
        public DoctorDataProvider provider = new DoctorDataProvider();

        public void Delete(Business.Models.Doctor model)
        {
            provider.Delete(model);
        }

        public void Update(Business.Models.Doctor model)
        {
            provider.Update(model);
        }

        public Business.Models.Doctor GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Business.Models.Doctor model)
        {
            provider.Create(model);
        }

        public IList<Business.Models.Doctor> GetList()
        {
            return provider.GetList();
        }
    }
}