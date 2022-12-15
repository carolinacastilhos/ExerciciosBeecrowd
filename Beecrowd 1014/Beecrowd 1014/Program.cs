using System; 

namespace Beecrowd_1014
{
    class Program
    {

        static void Main(string[] args)
        {

            int distance = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            double consumption = distance / fuel;

            Console.WriteLine($"{consumption:f3} km/l");

        }
    }
}