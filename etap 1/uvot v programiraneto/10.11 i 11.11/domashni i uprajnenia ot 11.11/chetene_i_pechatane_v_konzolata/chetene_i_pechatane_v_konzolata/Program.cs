using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chetene_i_pechatane_v_konzolata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double square;
            double a = double.Parse(Console.ReadLine());
            square = a * a;
            Console.WriteLine($"Square = {square}");
        }
    }
}
