using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//1
            //1 a
            Console.WriteLine("Введ x");
            double x = Convert.ToInt32(Console.ReadKey());
            double s = 2 * x;
            Console.WriteLine(s);
            Console.ReadKey();
            // 1в
            Console.WriteLine("Введ a");
            double a = Convert.ToInt32(Console.ReadKey());
            double b = a * a;
            Console.WriteLine(b);
            Console.ReadKey();
            //1д
            Console.WriteLine("ведитечисло q");
            double q = Convert.ToDouble(Console.ReadLine());
            double z = Math.Abs(q);
            Console.WriteLine(z);
            Console.ReadKey();
           


        }
    }
}
