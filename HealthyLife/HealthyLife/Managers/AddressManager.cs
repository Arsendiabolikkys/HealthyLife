using HealthyLife.Business.Models;
using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class AddressManager : IAddressManager
    {
        public AddressDataProvider provider = new AddressDataProvider();

        public int Add(Address model)
        {
            provider.Create(model);
            return model.Id;
        }

        public Address GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Address model)
        {
            throw new NotImplementedException();
        }

        public IList<Address> GetList()
        {
            return provider.GetList();
        }

        public void Delete(Address model)
        {
            provider.Delete(model);
        }

        public void Update(Address model)
        {
            provider.Update(model);
        }
    }
}