using System;
using System.Security.Cryptography.X509Certificates;

namespace Beecrowd_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');

            double coordenada1 = double.Parse(coordenadas[0]);
            double coordenada2 = double.Parse(coordenadas[1]);

            if (coordenada1 == 0 && coordenada2 == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (coordenada1 != 0 && coordenada2 == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (coordenada2 != 0 && coordenada1 == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (coordenada1 > 0 && coordenada2 > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (coordenada1 < 0 && coordenada2 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (coordenada1 < 0 && coordenada2 < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (coordenada1 > 0 && coordenada2 < 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
