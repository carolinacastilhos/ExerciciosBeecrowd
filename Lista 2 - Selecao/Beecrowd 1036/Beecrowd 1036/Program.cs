using System;

namespace Beecrowd_1036
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] numeros = Console.ReadLine().Split(' ');

            double n1 = double.Parse(numeros[0]);
            double n2 = double.Parse(numeros[1]);
            double n3 = double.Parse(numeros[2]);

            double delta = Math.Pow(n2, 2) - (4 * n1 * n3);

            double raiz1 = (-n2 + Math.Sqrt(delta)) / (2 * n1);

            double raiz2 = (-n2 - Math.Sqrt(delta)) / (2 * n1);

            if (delta < 0 || n1 == 0) 
            {
                Console.WriteLine($"Impossivel calcular");
               
            }
            else 
            {
                Console.WriteLine($"R1 = {raiz1:f5}\n" +
                    $"R2 = {raiz2:f5}");
            }
                




        }
        
    }
}