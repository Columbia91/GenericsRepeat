using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRepeat
{
    public class Drive : SystemEntity, IData
    {
        public string PrintInfo()
        {
            return "Информация о диске";
        }
    }
}
