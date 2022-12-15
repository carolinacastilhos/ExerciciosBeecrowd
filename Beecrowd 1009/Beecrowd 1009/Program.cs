using System; 

namespace Beecrowd_1009
{

    class Program
    {

        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double sale = double.Parse(Console.ReadLine());

            double total;

           total = (sale * 0.15) + salary;

            Console.WriteLine($"TOTAL = R$ {total:f2}");


        }
    }
}