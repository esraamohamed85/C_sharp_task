using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    abstract internal class Employee:User

    {
        public int Salary { get; set; }
        public string Type { get; set; }



        public void displayProjects()
        {

        }

        public void Bonus(iBonus bonus)
        {
            bonus.calcBonus(Salary);
                

        }
        
      


    }
}
