using HealthyLife.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Managers
{
    public class ScheduleManager : IScheduleManager
    {
        public ScheduleDataProvider provider = new ScheduleDataProvider();

        public void Delete(Business.Models.Schedule model)
        {
            provider.Delete(model);
        }

        public void Update(Business.Models.Schedule model)
        {
            provider.Update(model);
        }

        public Business.Models.Schedule GetById(int id)
        {
            return provider.GetById(id);
        }

        public void Create(Business.Models.Schedule model)
        {
            provider.Create(model);
        }

        public IList<Business.Models.Schedule> GetList()
        {
            return provider.GetList();
        }
    }
}