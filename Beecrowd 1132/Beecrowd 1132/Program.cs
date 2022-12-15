using System;

namespace Beecrowd_1132
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            int maior, menor;
            int soma = 0;
            
            if (valor1 < valor2)
            {
                menor = valor1;
                maior = valor2;
            }
            else
            {
                maior = valor1;
                menor = valor2;
            }

            for (int i = menor; i <= maior; i++)
            {
                
                if (i % 13 != 0)
                {
                    soma += i;
                }

            }

            Console.WriteLine(soma);

        }
    }
}