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
        {//2
            //2.г
            Console.WriteLine("Ведите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double t = a / (b * c);
            Console.WriteLine(t);
            Console.ReadKey();
            //2.B
            Console.WriteLine("Введите число а");
            double а = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число б");
            double б = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число с");
            double с = Convert.ToDouble(Console.ReadLine());
            double f = (a / b) * c;
            Console.WriteLine(f);
            Console.ReadKey();
            //2 б
            Console.WriteLine("Введите число а");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число б");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число с");
            double w = Convert.ToDouble(Console.ReadLine());
            double p = c / (d * w);
            Console.WriteLine(f);
            Console.ReadKey();





        }
    }
}
