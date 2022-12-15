using System;
    using System.Globalization;



namespace Beecrowd_1002
{
    class Program
    {

        static void Main(string[] args)
        {

            double raio, area;

            raio = double.Parse(Console.ReadLine());

            area = (3.14159 * raio * raio);

            Console.WriteLine($"A={area:f4}");

                

        }
    }
}
