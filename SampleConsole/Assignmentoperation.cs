using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    class Assignmentoperation
    {
        public void Assign ()
        {
            int a = 10;
            Console.WriteLine("'a' Value is ="+a);
            a += 10;
            Console.WriteLine("a+10 is:"+a);  //20
            a -= 10;
            Console.WriteLine("a-10 is:"+a);  //10
            a *= 10;
            Console.WriteLine("a*10 is:"+a);  //100
            a /= 10;
            Console.WriteLine("a/10 is:"+a);  //10
            a %= 10;
            Console.WriteLine("a%10 is:"+a);  //0
            Console.WriteLine();
        

        }
    }
}
