using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class IterationDemo
    {
        public static void printNumbers(int count)
        {
            Console.WriteLine($"Counting from 1 to {count}");
            for(var i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();
        }


        //Arrays

        public static void printArray(int[] array)
        {
            Console.WriteLine("The elements present in the array are:");
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }

    }
}
