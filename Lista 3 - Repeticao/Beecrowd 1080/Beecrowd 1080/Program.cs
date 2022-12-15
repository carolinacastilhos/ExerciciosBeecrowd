using System;

namespace Beecrowd_1080
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int valorMaior = 0;
            int posicao = 0;
            
            for (int i = 1; i <= 100; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                
                if (valor > valorMaior)
                {
                    valorMaior = valor;
                    posicao = i;
                }

            }

            Console.WriteLine($"{valorMaior}\n" +
                    $"{posicao}");


        }
    }
}