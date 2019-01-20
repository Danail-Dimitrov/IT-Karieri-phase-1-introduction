using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleepyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int neRab = int.Parse(Console.ReadLine());
            int minSun = 30000;
            int igraRab = 63;
            int igraNeRab = 127;
            int rabDni = 365 - neRab;
            int minIgra = neRab * igraNeRab + rabDni * igraRab;

            if (minSun < minIgra)
            {
                Console.WriteLine("Tom will run away");
                int mins = minIgra - minSun;
                int hours = (mins - mins % 60) / 60;
                mins %= 60;
                //{H} hours and {M} minutes more for play
                Console.WriteLine($"{hours} hours and {mins} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                int mins = minSun - minIgra;               
                //{H} hours and {M} minutes less for play
                int hours = (mins - mins % 60) / 60;
                mins %= 60;
                Console.WriteLine($"{hours} hours and {mins} minutes less for play");
            }
        }
    }
}
