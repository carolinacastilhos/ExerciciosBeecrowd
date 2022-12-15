using System;

namespace Beecrowd_1066
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadePositivos = 0;
            int quantidadeNegativos = 0;

            for (int i = 0; i < 5; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    quantidadePositivos++;
                   
                }
                else if (valor < 0)
                {
                    quantidadeNegativos++;
                }
                if (valor % 2 == 0)
                {
                    quantidadePares++;
                }
                else if (valor % 2 != 0)
                {
                    quantidadeImpares++;
                }

            }

            Console.WriteLine($"{quantidadePares} valor(es) par(es)\n" +
                $"{quantidadeImpares} valor(es) impar(es)\n" +
                $"{quantidadePositivos} valor(es) positivo(s)\n" +
                $"{quantidadeNegativos} valor(es) negativo(s)");
        }

    }
}