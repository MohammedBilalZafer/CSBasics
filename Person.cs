using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Person
    {
        public string Name;
        public int age;

        public Person(string Name, int age  ) {
            this.Name = Name;
            this.age = age;
        }

        public void PrintDetails(string Name, int age)
        {
            Console.WriteLine("Hi my name is {0}, and my age is {1} ", Name,age);
        }
    }

}
