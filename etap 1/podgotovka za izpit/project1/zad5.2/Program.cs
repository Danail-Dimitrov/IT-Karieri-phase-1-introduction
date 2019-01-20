using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for(char a1=(char)a;a1<=(char)122;a1++)
            {
                for (char b1 = (char)b; b1 <= (char)122; b1++)
                {
                    for (int n1 = 1; n1 < 9; n1++)
                    {
                        for (int n2 = 8; n2 >= 1; n2--)
                        {
                            if ((n1 + n2 == 9) && (a1 < b1))
                            {
                                Console.Write("{0}{1}{2}{3} ", a1, b1, n1, n2);
                            }
                        }
                    }
                }
            }
        }
    }
}
