using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        //Non Static Method
        public void Show()
        {
            Console.WriteLine("Hello Jee");
            Console.WriteLine("Whassup Bro ");
            Console.WriteLine("This is Non Static Method ");
        }

        //Static Method 
        public static void Show2()
        {
            Console.WriteLine("Hi Here Rubab");
            Console.WriteLine("This a Static Method");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Show();

            Program.Show2();
            Console.ReadLine();

            
        }
    }
}
