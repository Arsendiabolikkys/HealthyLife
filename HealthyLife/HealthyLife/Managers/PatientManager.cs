using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class PatientManager : IPatientManager
    {
        public PatientDataProvider provider = new PatientDataProvider();

        public void Delete(Business.Models.Patient model)
        {
            provider.Delete(model);
        }

        public void Update(Business.Models.Patient model)
        {
            provider.Update(model);
        }

        public Business.Models.Patient GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Business.Models.Patient model)
        {
            provider.Create(model);
        }

        public IList<Business.Models.Patient> GetList()
        {
            return provider.GetList();
        }
    }
}