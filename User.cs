using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public void login()
        {
            Console.WriteLine("welcome");
        }

        public void logout()
        {
            Console.WriteLine("Good bye");
        }
    }
}
