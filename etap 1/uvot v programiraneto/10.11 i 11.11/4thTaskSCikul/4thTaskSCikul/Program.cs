using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thTaskSCikul
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=10;i++)
            {               
                for (int x=1;x<=i;x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
