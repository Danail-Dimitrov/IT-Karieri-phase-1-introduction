using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5ot_izpita
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char c = (char)a;
            char d = (char)b;
         


            for (; c <= 122; c++)
            {
                for (; d < +122; d++)
                {
                    for (int n1 = 1; n1 < 9; n1++)
                    {
                        for (int n2 = 8; n2 >= 1; n2--)
                        {
                            if ((n1 + n2 == 9) && (d < c))
                            {
                                Console.Write("{0}{1}{2}{3} ", c, d, n1, n2);
                            }
                        }
                    }
                }
            }

        }
    }
}
