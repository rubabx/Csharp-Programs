using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public static string personName;
        public static int personAge;
        static Person()
        {
            personName = "Ali";
            personAge = 32;
            Console.WriteLine("Static Constructor Invoke");
        }

        public static void GetValue()
        {
            Console.WriteLine("Person name is: "+ personName);
            Console.WriteLine("Person age is: "+ personAge);
        }

        public Person()
        {
            Console.WriteLine("Default Constructor Invoke"  );
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            Person.GetValue();
            Person umer = new Person();
            Console.ReadLine();
            }
    }
}
