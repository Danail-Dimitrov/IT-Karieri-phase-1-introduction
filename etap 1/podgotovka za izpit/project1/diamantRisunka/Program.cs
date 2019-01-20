using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamantRisunka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            //purvi red
            Console.WriteLine("{0}{1}{0}",
            new string('.', n),
            new string('*', n * 3));

            //do srednia
            for(int i = n-1; i >0; i--)
            {
                Console.WriteLine("{0}*{1}*{0}",
                new string ('.',i),
                new string ('.', 5 * n - 2 - 2 * i));
            }

            //sredata
            Console.WriteLine("{0}",
            new string ('*',2*n+n*3)
            );

            //sled sredata
            int i = 1;

            for (i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', (5 * n - 2 - 2 * i)));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('*', (5 * n - 2 - 2 * i)));

        }
    }
}
