using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int exHr = int.Parse(Console.ReadLine());
            int exMin = int.Parse(Console.ReadLine());
            int stHr = int.Parse(Console.ReadLine());
            int stMin = int.Parse(Console.ReadLine());
            double a = 0, b = 0;

            double minEx = exHr * 60 + exMin;
            double minSt = stMin * 60 + stMin;
            double dif1 = minSt - minEx;
            double dif2 = minEx - minSt;

            if(dif1<60&& dif1 > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{dif1} minutes after the exam");
            }
            else if (dif1 > 60)
            {
                a = dif1 / 60;
                b = dif1 % 60;
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1:00} minutes after the exam",a,b);
            }
            else if (dif1 == 0)
            {
                Console.WriteLine("On time");
            }
            else if (dif2 <= 30 && dif2 > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{dif2} minutes befor the exam");
            }
            else if (dif2 > 30 && dif2 < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{dif2} minutes befor the exam");
            }
            else
            {
                a = Math.Abs(dif2 / 60);
                b = Math.Abs(dif2 % 60);
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1:00} minutes after the exam",a,b);
            }
        }
    }
}

/*using System;

class OnTimeForExam
{
    static void Main()
    {
        var examHours = int.Parse(Console.ReadLine());
        var examMinutes = int.Parse(Console.ReadLine());
        var studentHours = int.Parse(Console.ReadLine());
        var studentMinutes = int.Parse(Console.ReadLine());

        var examTime = examHours * 60 + examMinutes;
        var studentTime = studentHours * 60 + studentMinutes;
        var minutesDifference = studentTime - examTime;

        if (minutesDifference < -30)
            Console.WriteLine("Early");
        else if (minutesDifference <= 0)
            Console.WriteLine("On time");
        else
            Console.WriteLine("Late");

        if (minutesDifference != 0)
        {
            var hours = Math.Abs(minutesDifference / 60);
            var minutes = Math.Abs(minutesDifference % 60);
            if (hours > 0)
            {
                if (minutes < 10)
                    Console.Write(hours + ":0" + minutes + " hours");
                else
                    Console.Write(hours + ":" + minutes + " hours");
            }
            else
                Console.Write(minutes + " minutes");
            if (minutesDifference < 0)
                Console.WriteLine(" before the start");
            else
                Console.WriteLine(" after the start");
        }
    }
}*/

