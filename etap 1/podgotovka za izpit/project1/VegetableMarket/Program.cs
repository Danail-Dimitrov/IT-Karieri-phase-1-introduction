using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double zelCena = double.Parse(Console.ReadLine());
            double plodCena = double.Parse(Console.ReadLine());
            double zelKg = double.Parse(Console.ReadLine());
            double plodKg = double.Parse(Console.ReadLine());
            double kurs = 1.94;

            double cenVLv = (zelCena * zelKg) + (plodCena * plodKg);

            Console.WriteLine(cenVLv / kurs);
        }
    }
}
