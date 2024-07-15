using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Single Dimenstional Array
            int[] array = new int[3];

            array[0] = 4;
            array[1] = 5;
            array[2] = 6;
            Console.WriteLine("------------Single Dimentional Array---------------");

            for (int i=0; i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
            
           
            //2D Reactangular Array
            
              int[,] array1 = new int[3, 4]
            {
                {10,11,12,13},
                {14,15,16,17},
                {18,19,20,21}
            };

            Console.WriteLine("------------2D Multidimentinal Rectangular Array---------------");
            for (int i=0; i<array1.GetLength(0);i++)
            {
                for(int j=0; j<array1.GetLength(1);j++)
                {
                    Console.Write(array1[i,j] + " ");
                }
                Console.WriteLine();
            }
             
            //Jagged Multidimenional Array

            int[][] array2 = new int[3][];

            array2[0] = new[] {12 ,13,14,15,16,17,18,19,20 };
            array2[1] = new[] {21,22,23,24,25 };
            array2[2] = new[] {26,27,28 };

            //Access all elements with For Loop
            Console.WriteLine("------------Access By for loop---------------");
            for (int i=0; i<array2.GetLength(0);i++)
            {
                for(int j=0; j<array2[i].Length; j++ )
                {
                    Console.Write(array2[i][j]+ " ");
                }
                Console.WriteLine();
            }
          
            //Access all elements with Foreach Loop
            Console.WriteLine("------------Access By foreach loop---------------");
            

            foreach(int[] item in array2)
            {
                foreach (int i in item)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            
            //Intializing Array with user input
            Console.WriteLine("Enter length of array you want to make ");
            int num = int.Parse(Console.ReadLine());

            int[] array3 = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter Data of index {i}");
                int data = int.Parse(Console.ReadLine());
                array3[i] = data;
            }
            Console.WriteLine("-------------Data------------");
            foreach (int item in array3)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
            
        }
    }
}
