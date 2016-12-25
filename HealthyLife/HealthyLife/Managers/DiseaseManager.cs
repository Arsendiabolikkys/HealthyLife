using HealthyLife.Business.Models;
using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class DiseaseManager : IDiseaseManager
    {
        public DiseaseDataProvider provider = new DiseaseDataProvider();

        public void Delete(Disease model)
        {
            provider.Delete(model);
        }

        public void Update(Disease model)
        {
            provider.Update(model);
        }

        public Disease GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Disease model)
        {
            provider.Create(model);
        }

        public IList<Disease> GetList()
        {
            return provider.GetList();
        }
    }
}