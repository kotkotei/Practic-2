using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {//3
            //3 д
            Console.WriteLine("ведите число r1");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введитечисло r2");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double a = (1 / r1) + (1 / r2);
            Console.WriteLine(a);
            Console.ReadKey();
            //3 н
            Console.WriteLine("Введитечисло ad");
            double ad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введитечисло bc");
            double bc = Convert.ToDouble(Console.ReadLine());
            double f = (ad + bc) / ad;
            Console.WriteLine(f);
            Console.ReadKey();
            //3 б
            Console.WriteLine("ведите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ведите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ведите число x3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double g = x1 * x2 + x1 * x3 + x2 * x3;
            Console.WriteLine(g);
            Console.ReadKey();


        }
    }
}
