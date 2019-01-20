using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadrat_ot_zvezdi
{
    class Program
    {
        static void Main(string[] args)
        { 
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("*");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
