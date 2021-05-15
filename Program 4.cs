using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {//4
            //2
            double x1 = 2, y1 = -4, x2 = -8, y2 = 3, x3 = 6, y3 = -5, S, P;

            S = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));

            Console.WriteLine("Площадь треугольника равна: " + S);

            double AB, BC, AC;

            AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            AC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));

            P = AB + AC + BC;

            Console.WriteLine("Периметр треугольника: " + P);
            Console.ReadKey();
            //3.
            double r, h, s, v;
            r = h = 1.0;
            Console.Write("Введите радиус цилиндра R: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту цилиндра H: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---");
            s = 2 * Math.PI * r * h;
            v = Math.PI * r * r * h;
            Console.WriteLine("Площадь боковой поверхности цилиндра = {0}, Объем цилиндра = {1}\n", s, v);
            Console.Write("для продолжения нажмите Enter");
            Console.ReadLine();
            //1
            double a, b, s, p;
            Console.WriteLine("Enter a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToDouble(Console.ReadLine());
            s = a * b;
            p = 2 * (a + b);
            Console.WriteLine("Square = {0}", s);
            Console.WriteLine("Perimeter = {0}", p);
            Console.ReadKey();
        }
    }
}
