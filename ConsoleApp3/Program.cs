using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ООП6-1");
            Console.WriteLine("");

            Class1 arg1 = new Class1();
            arg1.Print();
            Class1 arg2 = new Class1(228);
            arg1.Print();
            Class1 arg3= new Class1(1488, 1337);
            arg2.Print();

            Console.WriteLine("");
            Console.WriteLine("ООП6-2");
            Console.WriteLine("");

            Class2 t1 = new Class2();
            Class2 t2 = new Class2();
            Class2 t3 = new Class2();
            t1.Write();
            t1.Print();
            t2.Write("Проект");
            t2.Print();
            t3.Write("Проект не готов");
            t3.Print();

            Console.WriteLine("");
            Console.WriteLine("ООП6-3");
            Console.WriteLine("");

            Class3 triangle = new Class3(15, 7, 1);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Class3 triangle2 = new Class3(12, 5, 13);

           

            Console.ReadLine();
        }
    }
}
