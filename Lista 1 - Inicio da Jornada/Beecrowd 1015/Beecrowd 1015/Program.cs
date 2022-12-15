using System;

namespace Beecrowd_1015
{

    class Program
    {

        static void Main(string[] args)
        {

            string[] point1 = Console.ReadLine().Split(' ');
            string[] point2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(point1[0]);
            double y1 = double.Parse(point1[1]);

            double x2 = double.Parse(point2[0]);
            double y2 = double.Parse(point2[1]);

            double distance = Math.Sqrt(((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)));

            Console.WriteLine($"{distance:f4}");

        }
    }
}