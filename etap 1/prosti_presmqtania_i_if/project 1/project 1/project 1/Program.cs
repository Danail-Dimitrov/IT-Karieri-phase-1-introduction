﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double perimetar = Math.PI * r * 2;
            Console.WriteLine("Area = " + Math.Round(area, 2));
            Console.WriteLine("Perimetar = " + Math.Round(perimetar, 2));
        }
    }
}
