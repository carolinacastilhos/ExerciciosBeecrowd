using System;
using System.Security.Cryptography.X509Certificates;

namespace Beecrowd_1078
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int numero = int.Parse(Console.ReadLine());

            int resultadomultiplicacao;
            int fator;

            for (fator = 1; fator <= 10; fator++)
            {
                resultadomultiplicacao = fator * numero;
                Console.WriteLine($"{fator} x {numero} = {resultadomultiplicacao}");
            }

            

        }
    }
}