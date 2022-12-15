using System;

namespace Beecrowd_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int valorA = int.Parse(valores[0]);
            int valorB = int.Parse(valores[1]);
            int valorC = int.Parse(valores[2]);

            int valorD = valorA;
            int valorE = valorB;
            int valorF = valorC;

                                                  
            if (valorD > valorE && valorD > valorF)
            {
                int aux = valorD;
                valorD = valorF;
                valorF = aux;
                
            }
            else if (valorE > valorD && valorE > valorF)
            {
                int aux = valorE;
                valorE = valorF;
                valorF = aux;
                
            }
            if (valorD > valorE)
            {
                int aux = valorD;
                valorD = valorE;
                valorE = aux;
            }

            Console.WriteLine($"{valorD}\n" +
                $"{valorE}\n" +
                $"{valorF}\n" +
                $"\n" +
                $"{valorA}\n" +
                $"{valorB}\n" +
                $"{valorC}");
        }
    }
}