using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    class Swappingfile
    {
        public void Swapp ()
        {
           /* int a = 10;
            int b = 20;

            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);*/

            Swapp2();
            
        }

        public void Swapp2 ()
        {
            Console.WriteLine("Enter The Numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Reassign Values : ");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
