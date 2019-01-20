using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZI_learning_hall
{
    class Program
    {
        static void Main(string[] args)
        {
            //rab mqsto 70 на 120 cm 
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            w *= 100;
            h *= 100;
            w -= 100;
            double mestaNaRed = Math.Floor (w / 70);
            double redove = Math.Floor(h / 120);
            double mesta = Math.Floor(mestaNaRed * redove-3);
            Console.WriteLine(mesta);
        }
    }
}
