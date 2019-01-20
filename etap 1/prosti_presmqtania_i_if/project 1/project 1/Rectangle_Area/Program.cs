using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = x1 - x2;
            double b = y2 - y1;
            double s = a * b;
            double p = a * 2 + b * 2;
            Console.WriteLine(Math.Abs(s));
            Console.WriteLine(Math.Abs(p));
        }
    }
}
