using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inches_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            double cm;
            Console.Write("Inches = ");
            double inches = double.Parse(Console.ReadLine());
            cm = inches * 2.54;
            Console.WriteLine($"centimeters = {cm}");
        }
    }
}
