using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRepeat
{
    public class DataService<T> where T : SystemEntity, IData, new() // new() конструктор по умолчанию
    {                                   // класс должен наследоваться SystemEntity,
        private readonly T data;
        public DataService(T data)
        {
            this.data = data;
        }
    }
}
