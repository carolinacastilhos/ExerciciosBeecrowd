using System;

namespace Beecrowd_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double ladoA = double.Parse(valores[0]);
            double ladoB = double.Parse(valores[1]);
            double ladoC = double.Parse(valores[2]);

            if (ladoC>ladoA && ladoC > ladoB)
            {
                double temp = ladoC;
                ladoC = ladoA;
                ladoA = temp;
            }
            else if (ladoB > ladoA && ladoB > ladoC)
            {
                double temp = ladoB;
                ladoB = ladoA;
                ladoA = temp;
            }
            
            if (ladoA >= ladoB + ladoC)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (ladoA * ladoA == ladoB * ladoB + ladoC * ladoC)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (ladoA * ladoA > ladoB * ladoB + ladoC * ladoC)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (ladoA * ladoA < ladoB * ladoB + ladoC * ladoC)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (ladoA == ladoB && ladoA != ladoC || ladoA == ladoC && ladoA != ladoB || ladoC == ladoB && ladoC !=ladoA)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}