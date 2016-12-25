using HealthyLife.Business.Models;
using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class DepartmentManager : IDepartmentManager
    {
        public DepartmentDataProvider provider = new DepartmentDataProvider();

        public Department GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Department model)
        {
            provider.Create(model);
        }

        public IList<Department> GetList()
        {
            return provider.GetList();
        }

        public void Delete(Department model)
        {
            provider.Delete(model);
        }

        public void Update(Department model)
        {
            provider.Update(model);
        }
    }
}