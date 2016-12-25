using HealthyLife.Business.Models;
using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class AccountManager : IAccountManager
    {
        public AccountDataProvider provider = new AccountDataProvider();

        SimpleCrypto.PBKDF2 crypto = new SimpleCrypto.PBKDF2();

        public Account GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Account model)
        {
            var encrPass = crypto.Compute(model.Password);

            model.Password = encrPass;
            model.PasswordSalt = crypto.Salt;

            provider.Create(model);
        }

        public void Update(Account model)
        {
            provider.Update(model);
        }

        public Account GetByEmail(string email)
        {
            return provider.GetByEmail(email);
        }

        public bool IsPasswordValid(string email, string password)
        {
            Account user = GetByEmail(email);
            if (user != null)
            {
                if (user.Password == crypto.Compute(password, user.PasswordSalt))
                {
                    return true;
                }
            }
            return false;
        }

        public IList<Account> GetList()
        {
            return provider.GetList();
        }

        public void Delete(Account model)
        {
            provider.Delete(model);
        }

        public int Add(Account model)
        {
            Create(model);
            return model.Id;
        }
    }
}