using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class3
    {
        public double a;
        public double b;
        public double c;
        public Class3(int l1, int l2, int l3)
        {
            a = l1; b = l2; c = l3;
            if ((a + b > c) && (b + c > a) && (c + a > b))
                Console.WriteLine("Возможно построить треугольник");
            else
                Console.WriteLine("Не возможно построить треугольни");

            double a1 = (Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c))) * (180 / Math.PI);
            double b1 = (Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * (180 / Math.PI);
            double c1 = (Math.Acos((Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a))) * (180 / Math.PI);

            Console.WriteLine("Угол A = {0:0.000}", a1);
            Console.WriteLine("Угол B = {0:0.000}", b1);
            Console.WriteLine("Угол C = {0:0.000}", c1);
        }
    }
}
