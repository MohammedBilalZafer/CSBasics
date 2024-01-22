using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class ControlFlow
    {
        public static void isPortarait(int length,int width)
        {
            
            if ( length >=  width)
            {
                Console.WriteLine("The image is a portrait");
            }
            else
            {
                Console.WriteLine("The image is a landscape");
            }
        }
    }
}
