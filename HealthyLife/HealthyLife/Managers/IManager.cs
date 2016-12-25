using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife.Managers
{
    public interface IManager<TType>
    {
        TType GetById(int id);

        void Create(TType model);

        IList<TType> GetList();
    }
}
