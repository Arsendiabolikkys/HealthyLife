using HealthyLife.Business.Models;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.DataProviders
{
    public class AccountDataProvider : DataProvider<Account>
    {
        public Account GetByEmail(string email)
        {
            Account result = null;
            Execute(session =>
            {
                var criteria = session.CreateCriteria(typeof(Account));
                criteria.Add(Restrictions.Eq(Constants.Account.Email, email));
                result = criteria.UniqueResult<Account>();
            });
            return result;
        }
    }
}