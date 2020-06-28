using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class2
    {
        string pole = "Пусто";
        public void Write()
        {

        }
        public void Write(string pole2)
        {
            if (pole2.Length > 10) pole2 = "Слишком длинная строка";
            else pole = pole2;
        }
        public void Print()
        {
            Console.WriteLine(pole);
        }
    }
}
