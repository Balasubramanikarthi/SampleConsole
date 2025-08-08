using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    class GlobalvariableandLocalvariable
    {
        string _name = "Money";
        int _money = 1000;
        public void Method1()
        {
            string name = "Amount";
            int amount = 100;

        }
        public void  Method2()
        {
            Console.WriteLine(_name);
            string name = "Savings";
        }
    }
}
