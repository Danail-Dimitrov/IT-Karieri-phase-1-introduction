using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAway = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double cat1 = double.Parse(Console.ReadLine());
            double cat2 = double.Parse(Console.ReadLine());

            double cat1Needs = cat1 * daysAway;
            double cat2Needs = cat2 * daysAway;
            double catsNeed = cat1Needs + cat2Needs;
            double a;

            if (catsNeed <= food)
            {
                a =Math.Ceiling( food - catsNeed);
               
                Console.WriteLine("The cats are well fed.");
                Console.WriteLine($"{a} kilos of food left.");
            }
            else
            {
                a = Math.Floor(catsNeed - food);
                Console.WriteLine("The cats are hungry.");
                Console.WriteLine($"{a} more kilos of food are needed.");
            }

        }
    }
}
