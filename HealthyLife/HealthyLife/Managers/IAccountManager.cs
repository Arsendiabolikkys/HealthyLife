using HealthyLife.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface IAccountManager : IManager<Account>
    {
        Account GetByEmail(string email);

        bool IsPasswordValid(string email, string password);

        void Update(Account model);

        void Delete(Account model);

        int Add(Account model);
    }
}
