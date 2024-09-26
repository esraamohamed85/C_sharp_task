using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Developer:Employee,iBonus
    {
        public  void calcBonus(int salary)
        {
            Console.WriteLine ((salary * 20) / 100 );
        }
    }
}
