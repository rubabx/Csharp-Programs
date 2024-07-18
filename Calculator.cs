using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition of these two number is: {result} ");
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtraction of these two number is: {result} ");
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplication of these two number is: {result} ");
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"Division of these two number is: {result} ");

        }
        static void Main(string[] args)

        {
            string confirm;
            do
            {
                Console.WriteLine("Enter First Number: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Operator you want to perform");
                Console.WriteLine(" +  -  /  * ");
                Console.WriteLine();
                string Operator = Console.ReadLine();

                if (Operator == "+")
                {
                    Program.Addition(number1, number2);
                }
                else if (Operator == "-")
                {
                    Program.Subtraction(number1, number2);
                }
                else if (Operator == "*")
                {
                    Program.Multiplication(number1, number2);
                }
                else if (Operator == "/")
                {
                    Program.Division(number1, number2);
                }
                else
                {
                    Console.WriteLine("invalid Operator");
                }

                Console.WriteLine("Do you want to Perform an operation again yes/no:");
                confirm = Console.ReadLine().ToLower();
            }


            while (confirm == "no");
            {
                Console.WriteLine("You enter \"No\" it means You donot want do perform any operation");
                Console.WriteLine("SO GOOD BYEEE!..");
            }
            Console.ReadLine();
        }
    }
}
