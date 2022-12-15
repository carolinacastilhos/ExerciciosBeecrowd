using System;

namespace Beecrowd_1072
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valorPrincipal = int.Parse(Console.ReadLine());

            int numerosDentroIntervalo = 0;
            int numerosForaIntervalo = 0;

            for (int i = 0; i < valorPrincipal; i++)
            {
                int numeros = int.Parse(Console.ReadLine());

                if (numeros >= 10 && numeros <= 20)
                {
                    numerosDentroIntervalo++;
                }
                else
                {
                    numerosForaIntervalo++;
                }

            }

            Console.WriteLine($"{numerosDentroIntervalo} in\n" +
                $"{numerosForaIntervalo} out");







        }
    }
}
