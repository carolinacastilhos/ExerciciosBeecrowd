using System;
using System.Net.Http.Headers;

namespace Beecrowd_1066
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quantidadePositivos = 0;
            double soma = 0;
            double media;

            for (int i = 0; i < 6; i++)
            {
                double valor = double.Parse(Console.ReadLine());
                
                if (valor > 0)
                {
                    quantidadePositivos += 1;
                    soma += valor;
                }
                               
            }

            media = soma / quantidadePositivos;
            Console.WriteLine($"{quantidadePositivos} valores positivos\n" +
                $"{media:f1}");



        }
    }
}
