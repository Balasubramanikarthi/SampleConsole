using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    class Aritmeticwork
    {
        public void Maths ()
        {
            Console.WriteLine(180/10);
            int a = 180 % 10;
            Console.WriteLine(a + 30);

            Maths2();
        }

        public void Maths2 ()
        {
            int a = 100;
            int b = 200;

            b = ++b;
            a = (b++) + b;
            Console.WriteLine(b);
            Console.WriteLine(a);

           
        }
    }
}
