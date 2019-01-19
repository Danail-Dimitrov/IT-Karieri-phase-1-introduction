using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finds the square area of a given figure
            string figure = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = 0;
            double s = 0;

            if (figure == "square")
            {
                s = a * a;
            }
            else if (figure == "rectangle")
            {
                b = double.Parse(Console.ReadLine());
                s = a * b;
            }
            else if (figure == "circle")
            {
                s = Math.Pow(a, 2) * Math.PI;
            }
            else
            {
                b = double.Parse(Console.ReadLine());
                s = (a * b) / 2;
            }
            Console.WriteLine(s);
        }
    }
}
