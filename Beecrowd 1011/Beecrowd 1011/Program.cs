using System;

namespace Beecrowd_1011
{
    class Program
    {

static void Main(string[] args)
        {
            double R, volume;

            R = double.Parse(Console.ReadLine());

            volume = (4 / 3.0) * 3.14159 * R * R * R;

            Console.WriteLine($"VOLUME = {volume:f3}");

        }
    }
}