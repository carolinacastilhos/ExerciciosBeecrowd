using System;

namespace Beecrowd_1019
{
    class Program
    {

        static void Main(string[] args)
        {
            int durationEvent = int.Parse(Console.ReadLine());

            int hour, quantHour, restHour, minute, quantMinute, restMinute, second, quantSecond; 

           hour = 3600;
           quantHour = durationEvent / hour;
           restHour = durationEvent % hour;

           minute = 60;
            quantMinute = restHour / minute;
            restMinute = restHour % minute;

            second = 1;
            quantSecond= restMinute / second;


         Console.WriteLine($"{quantHour}:{quantMinute}:{quantSecond}");
        }
    }
}
