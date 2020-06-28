using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
         int a1;
         int a2;
        public Class1()
        {

        }
        public Class1(int num)
        {
            a1 = num;
        }
        public Class1(int num, int num2)
        {
            a1 = num;
            a2 = num2;
        }
        public void Print()
        {
            Console.WriteLine(a1 + " ; " + a2);
        }
    }
}
