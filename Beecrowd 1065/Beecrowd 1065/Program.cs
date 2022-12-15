using System;

namespace Beecrowd_1065
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quantidadeNumerosPares = 0;

            for (int i = 0; i < 5; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    quantidadeNumerosPares++;  

                }
            }

            Console.WriteLine($"{quantidadeNumerosPares} valores pares");

        }
    }
}
