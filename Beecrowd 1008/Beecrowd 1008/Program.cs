using System;

namespace Beecrowd_1008
{

    class Program
    {

        static void Main(string[] args)
        {

            int number, hourMonth;
            double perHour, salary;

            number = int.Parse(Console.ReadLine());
            hourMonth= int.Parse(Console.ReadLine());
            perHour = double.Parse(Console.ReadLine());

            salary = hourMonth * perHour;

            Console.WriteLine($"NUMBER = {number}");

            Console.WriteLine($"SALARY = U$ {salary:f2}"); 
        }
    }
}