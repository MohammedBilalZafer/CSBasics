using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Calculate
    {
        public void add(int a,int b)
        {
            var result = a+ b;
            Console.WriteLine("Additon: " + result);
        }
        public void subtract(int a, int b)
        {
            var result = a - b;
            Console.WriteLine("Subtraction: " + result);
        }
    }
}
