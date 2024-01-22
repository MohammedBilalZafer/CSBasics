using CSharpBasics;
using System;
 
namespace cSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter your Name and age:");
            var name = Console.ReadLine();
            var age = Convert.ToInt32(Console.ReadLine()); 
            Person person = new Person(name,age);
            person.PrintDetails(name, age);

            //Arithmetic operations
            Console.WriteLine("Enter two numbers to perform arithmetic operations");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            Calculate calc = new Calculate();
            calc.add(a,b);
            calc.subtract(a,b);

            //Iterations
            Console.WriteLine("Enter the number to count:");
            var count = Convert.ToInt32(Console.ReadLine());
            IterationDemo.printNumbers(count);

            //ArrayIteration
            Random random = new Random(); 
            var integers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                integers.Append(random.Next());
            }
            IterationDemo.printArray(integers);


            //Control Flow statements
            Console.WriteLine("Enter the dimensions of an image");
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            ControlFlow.isPortarait(length,width);

        }
    }
}