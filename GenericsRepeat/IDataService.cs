using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRepeat
{
    public interface IDataService<V>
    {
        void Add(V entity);
        void Update(V entity);
    }
}
