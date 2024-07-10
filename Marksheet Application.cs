//Grademarks Application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
           Console.WriteLine("Enter Your Class: ");
           string standard = Console.ReadLine();
            Console.WriteLine("Enter your name");
           string name = Console.ReadLine();
            Console.WriteLine("Enter your roll number");
            string roll = Console.ReadLine();
            Console.WriteLine("Enter your Biology marks");
            int bio =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Physice marks");
            int phy =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your chemistry marks");
            int chem =  Convert.ToInt32(Console.ReadLine());

            int obtainmarks = bio+phy+chem;
            int percentage = (obtainmarks / 300) *100;

            Console.WriteLine("----------------Marksheet----------------");
            Console.WriteLine($"Your class is {class}");
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your rollnumber is {roll}");
            Console.WriteLine($"Your Total maerks is {obtainmarks}");
            Console.WriteLine($"Your percentage is {percentage}");

            if (percentage >=80)
            {
                Console.WriteLine("Your Grade is A+");
            }
            if (percentage >=70)
            {
                Console.WriteLine("Your Grade is A");
            }
            if (percentage >=60)
            {
                Console.WriteLine("Your Grade is B+");
            }
            if (percentage >=50)
            {
                Console.WriteLine("Your Grade is B");
            }
            if (percentage >=40)
            {
                Console.WriteLine("Your Grade is D");
            }
            if (percentage <=30)
            {
                Console.WriteLine("Your Grade is F");
            }





            Console.ReadKey();


        }
    }
}
