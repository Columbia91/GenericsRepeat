using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Строгая типизация
            int[] numbersAsArray = { 1, 2, 3, 4, 5 };
            
            // проблема в том, что тут может быть любой тип (object)
            ArrayList arrayList = new ArrayList
            {
                1,2,3,4,5
            };

            // Строгая типизация
            List<int> numbersAsList = new List<int>
            {
                1,2,3,4,5
            };
        }
    }
}
