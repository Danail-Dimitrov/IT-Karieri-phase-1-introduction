using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location;
            string type;
            double procent;


            if (money <= 100)
            {
                location = "Bulgaria";
                if (season == "summer")
                {
                    type = "Camp";
                    procent = 30;
                }
                else
                {
                    type = "Hotel";
                    procent = 70;
                }
            }
            else if (money <= 1000)
            {
                location = "Balkans";
                if (season == "summer")
                {
                    type = "Camp";
                    procent = 40;
                }
                else
                {
                    type = "Hotel";
                    procent = 80;
                }
            }
            else
            {
                procent = 90;
                type = "Hotel";
                location = "Europe";
            }
            Console.WriteLine("Somewhere in {0}", location);
            Console.WriteLine("{0} - {1:f2}",type,money* procent / 100);
        }
    }
}
