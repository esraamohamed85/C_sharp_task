﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Hr:Employee,iBonus
    {
       public void calcBonus(int salary)
        {
            Console.WriteLine((salary * 10) / 100);
        }
    }
}
