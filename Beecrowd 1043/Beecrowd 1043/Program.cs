using System;

namespace Beecrowd_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double valor1 = double.Parse(valores[0]);
            double valor2 = double.Parse(valores[1]);
            double valor3 = double.Parse(valores[2]);

            if (valor1 < valor2 + valor3 && valor2 < valor1 + valor3 && valor3 < valor2 + valor1)
            {
                double perimetro = valor1 + valor2 + valor3;
                Console.WriteLine($"Perimetro = {perimetro:f1}");
            }
            else
            {
                double area = ((valor1 + valor2) * valor3) / 2;
                Console.WriteLine($"Area = {area:f1}");
            }
        }
    }
}