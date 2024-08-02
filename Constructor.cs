//Name and Location using a Constructor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        public Program(string name, string location)
        {
            Console.WriteLine("My Name is:" + name);
            Console.WriteLine("My Loaction is:" + location);
              
        }
        static void Main(string[] args)
        {
            Program obj = new Program("Rubab", "Gujranwala");
            Console.ReadLine();
        }
    }
}
