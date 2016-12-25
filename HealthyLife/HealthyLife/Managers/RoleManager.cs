using HealthyLife.Business.Models;
using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class RoleManager : IRoleManager
    {
        public RoleDataProvider provider = new RoleDataProvider();

        public Role GetByName(string role)
        {
            return provider.GetByName(role);
        }

        public Role GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Role model)
        {
            provider.Create(model);
        }

        public IList<Role> GetList()
        {
            return provider.GetList();
        }
    }
}