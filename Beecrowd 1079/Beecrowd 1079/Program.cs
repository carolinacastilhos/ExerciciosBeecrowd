using System;
namespace Beecrowd_1079
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroPrincipal = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroPrincipal; i++)
            {
                string[] numerosTeste = Console.ReadLine().Split(' ');
                double numero1 = double.Parse(numerosTeste[0]);
                double numero2 = double.Parse(numerosTeste[1]);
                double numero3 = double.Parse(numerosTeste[2]);

                double media = ((numero1 * 2) + (numero2 * 3) + (numero3 * 5)) / 10;

                Console.WriteLine($"{media:f1}");
            }




        }
    }
}