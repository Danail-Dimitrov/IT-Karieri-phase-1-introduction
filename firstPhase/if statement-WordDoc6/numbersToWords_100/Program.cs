using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersToWords_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //reads a number betwen 0 and 100 and writes it in text
         
            int a = int.Parse(Console.ReadLine());
            string firstPart = null;
            string secondPart =null;
            string secondPartSpecial = null;//only for a>12 && a<20

            //finds the first and the second digit
            int firstDigit = 0;
            int secondDigit = a % 10;
            if (a > 12)
            {
                firstDigit = (a / 10) % 10;
            }

            //gives value to secondPart
            if (secondDigit == 1)
            {
                secondPart = "one";
            }
            else if (secondDigit == 2)
            {
                secondPart = "two";
            }
            else if (secondDigit == 3)
            {
                secondPart = "three";
            }
            else if (secondDigit == 4)
            {
                secondPart = "four";
            }
            else if (secondDigit == 5)
            {
                secondPart = "five";
            }
            else if (secondDigit == 6)
            {
                secondPart = "six";
            }
            else if (secondDigit == 7)
            {
                secondPart = "seven";
            }
            else if (secondDigit == 8)
            {
                secondPart = "eight";
            }
            else if (secondDigit == 9)
            {
                secondPart = "nine";
            }

            //gives value to firstPart
            if (firstDigit == 1)
            {
                secondPartSpecial = "teen";
            }
            else if (firstDigit == 2)
            {
                firstPart = "twenty";
            }
            else if (firstDigit == 3)
            {
                firstPart = "thirty";
            }
            else if (firstDigit == 4)
            {
                firstPart = "forty";
            }
            else if (firstDigit == 5)
            {
                firstPart = "fifty";
            }
            else if (firstDigit == 6)
            {
                firstPart = "sixty";
            }
            else if (firstDigit == 7)
            {
                firstPart = "seventy";
            }
            else if (firstDigit == 8)
            {
                firstPart = "eighty";
            }
            else if (firstDigit == 9)
            {
                firstPart = "ninety";
            }

            //finds what to write
            if (a < 0 || a > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (a == 0)
            {
                Console.WriteLine("zero");
            }
            else if (a <= 9)
            {
                Console.WriteLine(secondPart);
            }
            else if (a <= 12)
            {
                if (a == 10)
                {
                    Console.WriteLine("ten");
                }
                else if (a == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (a == 12)
                {
                    Console.WriteLine("twelve");
                }
            }
            else if (a <= 19)
            {
                if (a == 13)
                {
                    Console.WriteLine("thirteen");
                }
                else if (a == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else
                {
                    Console.WriteLine(secondPart + secondPartSpecial);
                }
            }
            else if (a == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine(firstPart +" "+ secondPart);
            }
        }
    }
}
