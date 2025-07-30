using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    class Aritmeticoperators
    {
        public void Addition()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("Addition Answer Is : "+c);
            Console.WriteLine();
        }
        public void Subtraction()
        {
            int a = 20;
            int b = 10;
            int c = a - b;
            Console.WriteLine("Subtraction Answer Is : "+c);
            Console.WriteLine();
        }
        public void Multiplication()
        {
            int a = 10;
            int b = 20;
            int c = a * b;
            Console.WriteLine("Multiplication Answer Is : "+c);
            Console.WriteLine();
        }
        public void Division()
        {
            int a = 20;
            int b = 10;
            int c = a / b;
            Console.WriteLine("Division Answer Is : "+c);
            Console.WriteLine();
        }
        public void Modulus()
        {
            int a = 10;
            int b = 20;
            int c = a % b;
            Console.WriteLine("Modulus Answer Is : "+ c);
        }
        public void Dynamic ()
        {
            Console.WriteLine();
            Console.Write("Enter The 1st Number :");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter The 2nd Number :");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine();
            Console.Write("The Addition Answer Is :"+c);
            Console.WriteLine();
            Console.WriteLine();


        }
        public void Dynamic2()
        {
            Console.WriteLine("Enter The First And Second Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;
            Console.WriteLine("Addition:"+c);
            Console.WriteLine();
            Console.WriteLine("Subtraction:"+d);
            Console.WriteLine();
            Console.WriteLine("Multiplication:"+e);
            Console.WriteLine();
            Console.WriteLine("Division:"+f);
            Console.WriteLine();
            Console.WriteLine("Modulus:"+g);
            Console.WriteLine();

        }
        
    }
}
