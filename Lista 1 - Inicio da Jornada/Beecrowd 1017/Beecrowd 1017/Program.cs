using System;

namespace Beecrowd_1017
{
    class Program
    {
        static void Main(string[] args)
        {

            int tripHours = int.Parse(Console.ReadLine());
            int tripSpeed = int.Parse(Console.ReadLine());

            int carUse = 12; 

            double distance = tripHours* tripSpeed;

            double tripFuel = distance / carUse;

            Console.WriteLine($"{tripFuel:f3}");

        }
    }
}