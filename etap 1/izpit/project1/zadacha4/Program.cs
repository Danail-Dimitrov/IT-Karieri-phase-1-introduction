using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int foodNeeded = 0;
            int a,b;

            int foodGr = food * 1000;
            for(int i = 0; i < days; i++)
            {
                a = int.Parse(Console.ReadLine());
                foodNeeded += a;
            }
            if (foodGr >= foodNeeded)
            {
                b = foodGr - foodNeeded;
                Console.WriteLine($"Food is enough! Leftovers: {b} grams.");
            }
            else
            {
                b = foodNeeded - foodGr;
                Console.WriteLine($"Food is not enough. You need {b} grams more.");
            }
        }
    }
}
