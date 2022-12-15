using System;
using System.Runtime.Serialization;

namespace Beecrowd_1071
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

            for (int i = menor+1; i < maior; i ++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
           

        }
    }
}