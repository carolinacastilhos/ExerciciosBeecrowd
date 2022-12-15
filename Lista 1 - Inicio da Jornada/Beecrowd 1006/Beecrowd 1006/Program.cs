using System;

namespace Beecrowd_1006
{

    class Program
    {

        static void Main(string[] args)
        {

            double notaA, notaB, notaC, pesoA, pesoB, pesoC, media;

            notaA = double.Parse(Console.ReadLine());
            notaB = double.Parse(Console.ReadLine());
            notaC = double.Parse(Console.ReadLine());

            pesoA = 2;
            pesoB = 3;
            pesoC = 5;

            media = ((notaA * pesoA) + (notaB * pesoB) + (notaC * pesoC)) / (pesoA + pesoB + pesoC);

            Console.WriteLine($"MEDIA = {media:f1}");

        }
    }
}