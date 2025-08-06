using System;
using ComputerClass;

namespace SampleConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aritmeticoperators maths = new Aritmeticoperators();
            //maths.Addition();
            //maths.Subtraction();
            //maths.Multiplication();
            //maths.Division();
            //maths.Modulus();
           // maths.Dynamic();
           // maths.Dynamic2();

           // Assignmentoperation assign = new Assignmentoperation();
            //assign.Assign();

           // new ClassMembers().Member();

          // new Swappingfile().Swapp();

            new Aritmeticwork2().Maths();

            Console.WriteLine(3-8+5*2-3*2);
            Console.WriteLine();
            Console.WriteLine(3 - 8 +( 5 * 2) - (3 * 2));





        }
    }
}
