using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second  number");
            int num2 = int.Parse(Console.ReadLine());

            Add obj = new Add();
            obj.a = num1;
            obj.b = num2;

            //Swapping
            num1 = num2;
            num2 = obj.a;

            Console.WriteLine("First Number is: " + num1);
            Console.WriteLine("Second Number is: " + num2);
            Console.ReadLine();
        }
    }
}