using System;
using System.Runtime.Serialization;

namespace Beecrowd_1101
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);

            while (valor1 > 0 && valor2 > 0)
            {
                int maior, menor, i;
                int soma = 0;

                if (valor1 > valor2)
                {
                    maior = valor1;
                    menor = valor2;
                }
                else
                {
                    maior = valor2;
                    menor = valor1;
                }


                for (i = menor; i <= maior; i++)
                {
                    
                    soma += i;

                    Console.Write($"{i} ");
                }

                
                Console.WriteLine($"Sum={soma}");
                
                valores = Console.ReadLine().Split(' ');
                valor1 = int.Parse(valores[0]);
                valor2 = int.Parse(valores[1]);


            }


        }
    }
}