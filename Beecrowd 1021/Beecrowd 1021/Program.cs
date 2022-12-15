using System;

namespace Beecrowd_1021
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor = double.Parse(Console.ReadLine());

            int valorNotas = (int)(valor);

            double moedas = Math.Floor((valor - valorNotas) * 100);

            int valorMoedas = (int)(moedas);

            int nota100 = valorNotas / 100;
            valorNotas -= nota100 * 100;

            int nota50 = valorNotas / 50;
            valorNotas -= nota50 * 50;

            int nota20 = valorNotas / 20;
            valorNotas -= nota20 * 20;

            int nota10 = valorNotas / 10;
            valorNotas -= nota10 * 10;

            int nota5 = valorNotas / 5;
            valorNotas -= nota5 * 5;

            int nota2 = valorNotas / 2;
            valorNotas -= nota2 * 2;

            int moeda1 = valorNotas / 1;
            valorNotas -= moeda1 * 1;

            int moeda50 = valorMoedas/ 50;
            valorMoedas -= moeda50 * 50;

            int moeda25 = valorMoedas / 25;
            valorMoedas -= moeda25 * 25;

            int moeda10 = valorMoedas / 10;
            valorMoedas -= moeda10* 10;

            int moeda05 = valorMoedas / 5;
            valorMoedas -= moeda05* 5;

            int moeda01 = valorMoedas / 1;
            
                   

            Console.WriteLine($"NOTAS:\n" +
                $"{nota100} nota(s) de R$ 100.00\n" +
                $"{nota50} nota(s) de R$ 50.00\n" +
                $"{nota20} nota(s) de R$ 20.00\n" +
                $"{nota10} nota(s) de R$ 10.00\n" +
                $"{nota5} nota(s) de R$ 5.00\n" +
                $"{nota2} nota(s) de R$ 2.00\n" +
                $"MOEDAS:\n" +
                $"{moeda1} moeda(s) de R$ 1.00\n" +
                $"{moeda50} moeda(s) de R$ 0.50\n" +
                $"{moeda25} moeda(s) de R$ 0.25\n" +
                $"{moeda10} moeda(s) de R$ 0.10\n" +
                $"{moeda05} moeda(s) de R$ 0.05\n" +
                $"{moeda01} moeda(s) de R$ 0.01");


        }
    }
}

