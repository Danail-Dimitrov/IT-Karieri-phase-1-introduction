using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double a,b,otg;
            

            Console.Write("Enter a: ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            a = Convert.ToDouble(userInput);

            Console.Write("Enter b: ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            b = Convert.ToDouble(userInput);

            otg = a * b;
            Console.WriteLine(otg);




        }
    }
}
