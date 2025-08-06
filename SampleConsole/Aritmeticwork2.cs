using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    class Aritmeticwork2
    {
        public void Maths ()
        {
            string a = "ice";
            string b = "Cream";
            string c = a + b;
            Console.Write(c);
            Maths2();
        }
        public void Maths2()
        {
            
            new Aritmeticwork().Maths();

        }
    }
}
