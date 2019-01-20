using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reshavane_na_zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            //area = a * h / 2
            //Triangle area = 300
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine($"Triangle area = {(a * h) / 2}");
        }
    }
}
