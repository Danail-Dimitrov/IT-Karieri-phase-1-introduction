using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumirane_na_selundi
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int min=0;
            int seconds = first + second + third;
            if (seconds < 60)
            {
                min += 0;
            }
            else if (seconds < 120)
            {
                min += 1;
                seconds -= 60;
            }
            else if (seconds >= 120)
            {
                min = 2;
                seconds -= 120;
            }
            if (seconds < 10)
            {
                Console.WriteLine($"{min}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{min}:{seconds}");
            }        
        }
    }
}
