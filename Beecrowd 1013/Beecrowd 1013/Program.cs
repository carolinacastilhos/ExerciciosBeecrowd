using System;

namespace Beecrowd_1013
{

    class Program
    {

        static void Main(string[] args)
        {

            string[] numeros = Console.ReadLine().Split(' ');

            int numero1 = int.Parse(numeros[0]);
            int numero2 = int.Parse(numeros[1]);
            int numero3 = int.Parse(numeros[2]);

            int numeroMaior = (numero1 + numero2 + Math.Abs(numero1 - numero2)) / 2;
            numeroMaior = (numeroMaior + numero3 + Math.Abs(numeroMaior - numero3)) / 2;

            Console.WriteLine($"{numeroMaior} eh o maior");




        }
    }
}
