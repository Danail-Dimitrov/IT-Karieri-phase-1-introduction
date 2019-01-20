using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Якета - 120 лв.
            //Каски – 75 лв.
            //Комплект обувки – 299,90 лв.
            int qke = 120;
            int kaska = 75;
            double obuvki = 299.90;

            int n = int.Parse(Console.ReadLine());
            int qkeBuy = int.Parse(Console.ReadLine());
            int kaskaBuy = int.Parse(Console.ReadLine());
            int obuvkiBuy = int.Parse(Console.ReadLine());

            int qkeToPay = qke * qkeBuy;
            int kaskaToPay = kaska * kaskaBuy;
            double obuvkiToPay = obuvki * obuvkiBuy;

            double onePerson = obuvkiToPay + qkeToPay + kaskaToPay;
            double allPeople = onePerson * n;
            double mustPay = allPeople+(allPeople * 20 / 100);

            Console.WriteLine(mustPay);
        }
    }
}
