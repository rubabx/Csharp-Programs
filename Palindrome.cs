//Palindrome Number 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            
            int rem, result = 0;

            int temp = num;
            while (num != 0)
            { 
            rem = num % 10;
            result = result*10 + rem;
            num /= 10;
           
        }
           
            if (temp == result)
            {
                Console.WriteLine("It is a Palindrome number");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome number");
            }
            Console.ReadLine();
        }
    }
}
