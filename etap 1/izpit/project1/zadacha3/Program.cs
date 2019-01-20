using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double toPay;

            if (days < 10)
            {
                if (type== "apartment")
                {
                    toPay = (days * 70.0) - (days * 70.0) * 30 / 100;
                }
                else
                {
                    toPay = (days * 125.0) - (days * 125.0) * 10 / 100;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                if (type == "apartment")
                {
                    
                    toPay = (days * 70.0) - (days * 70.0) * 35 / 100;
                }
                else
                {
                    
                    toPay = (days * 125.0) - (days * 125.0) * 15 / 100;
                }
            }
            else
            {
                if (type == "apartment")
                {
                    toPay = (days * 70.0) - (days * 70.0) * 50 / 100;
                }
                else
                {
                    toPay = (days * 125.0) - (days * 125.0) * 20 / 100;
                }
            }
            Console.WriteLine("{0:f2}",toPay);
        }
    }
}
