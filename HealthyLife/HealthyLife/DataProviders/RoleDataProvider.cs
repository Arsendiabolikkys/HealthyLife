using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Criterion;

namespace HealthyLife.DataProviders
{
    public class RoleDataProvider : DataProvider<Role>
    {
        public Role GetByName(string role)
        {
            return Execute(session =>
            {
                var criteria = session.CreateCriteria<Role>();
                criteria.Add(Restrictions.Eq(Constants.Role.Name, role));
                return criteria.UniqueResult<Role>();
            });
        }
    }
}