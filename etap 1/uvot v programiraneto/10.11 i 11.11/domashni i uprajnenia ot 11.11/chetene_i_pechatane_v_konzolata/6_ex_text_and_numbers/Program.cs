using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ex_text_and_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are <firstName> <lastName>, a <age>-years old person from <town>.
            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your first last : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your age : ");
            string age = Console.ReadLine();
            Console.Write("Enter your town : ");
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
