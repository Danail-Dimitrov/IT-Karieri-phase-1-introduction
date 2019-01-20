using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi strana a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi strana b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"area = {a * b}");
        }
    }
}
