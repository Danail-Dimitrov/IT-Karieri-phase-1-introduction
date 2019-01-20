using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            double n = int.Parse(Console.ReadLine());
            double a;
            for(int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < 200)
                {
                    p1 += 1;
                }
                else if(a >= 200 && a <= 399)
                {
                    p2 += 1;
                }
                else if(a >= 400 && a <= 599)
                {
                    p3 += 1;
                }
                else if(a >= 600 && a <= 799)
                {
                    p4 += 1;
                }
                else if (a>800)
                {
                    p5 += 1;
                }
            }
            double x1 = p1 / n * 100;
            double x2 = p2 / n * 100;
            double x3 = p3 / n * 100;
            double x4 = p4 / n * 100;
            double x5 = p5 / n * 100;
            Console.Write("{0:f2}",x1);
            Console.WriteLine("%");
            Console.Write("{0:f2}",x2);
            Console.WriteLine("%");
            Console.Write("{0:f2}",x3);
            Console.WriteLine("%");
            Console.Write("{0:f2}",x4);
            Console.WriteLine("%");
            Console.Write("{0:f2}",x5);
            Console.WriteLine("%");
        }
    }
}
