using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            double price = 0;

            if (km < 20)
            {
                price += 0.7;
                if (dayTime == "day")
                {
                    price += km * 0.79;
                }
                else
                {
                    price += km * 0.90;
                }
            }
            else if (km < 100)
            {
                price +=km* 0.09;
            }
            else
            {
                price += km * 0.06;
            }
            Console.WriteLine("{0:f2}", price);
        }
    }
}
