using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            //nwlmo
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double ploshtS = n * n;
            double peikaS = o * m;
            double plochkaS = w * l;
            double a,b;
            a = ploshtS - peikaS;
            b = a / plochkaS;

            Console.WriteLine(b);
            Console.WriteLine(b*0.2);
        }
    }
}
