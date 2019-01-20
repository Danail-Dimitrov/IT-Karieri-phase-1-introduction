using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string produkt = Console.ReadLine();
            string city = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
            double toPay;

            /*продукт  coffee water   beer sweets  peanuts
              Sofia   0.50    0.80    1.20    1.45    1.60
              Plovdiv 0.40    0.70    1.15    1.30    1.50
              Varna   0.45    0.70    1.10    1.35    1.55*/



            if (city == "Sofia")
            {
                if (produkt == "coffee")
                {
                    toPay = n * 0.50;
                }
                else if (produkt == "water")
                {
                    toPay = n * 0.80;
                }
                else if (produkt == "beer")
                {
                    toPay = n * 1.20;
                }
                else if (produkt == "sweets")
                {
                    toPay = n * 1.45;
                }
                else
                {
                    toPay = n * 1.60;
                }
            }
            else if (city == "Varna")
            {
                if (produkt == "coffee")
                {
                    toPay = n * 0.45;
                }
                else if (produkt == "water")
                {
                    toPay = n * 0.70;
                }
                else if (produkt == "beer")
                {
                    toPay = n * 1.10;
                }
                else if (produkt == "sweets")
                {
                    toPay = n * 1.35;
                }
                else
                {
                    toPay = n * 1.55;
                }
            }
            else
            {
                if (produkt == "coffee")
                {
                    toPay = n * 0.40;
                }
                else if (produkt == "water")
                {
                    toPay = n * 0.70;
                }
                else if (produkt == "beer")
                {
                    toPay = n * 1.15;
                }
                else if (produkt == "sweets")
                {
                    toPay = n * 1.30;
                }
                else
                {
                    toPay = n * 1.50;
                }
            }
            Console.WriteLine(toPay);
        }
    }
}
