using System;

namespace Beecrowd_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] dadosArea = Console.ReadLine().Split(' ');

            //Area do triângulo retângulo = (a*b)/2

            double areaTri = (double.Parse(dadosArea[0]) * double.Parse(dadosArea[2])) / 2.0;

            //Area do Circulo = c*2pi

            double areaCir = (double.Parse(dadosArea[2]) * double.Parse(dadosArea[2])) * 3.14159;

            //Area do Trapezio = 1/2*c(a+b)

            double areaTra = (1 / 2.0) * double.Parse(dadosArea[2]) * (double.Parse(dadosArea[0]) + double.Parse(dadosArea[1]));

            //Area do Quadrado = b*b

            double areaQua = double.Parse(dadosArea[1]) * double.Parse(dadosArea[1]);

            //Area do Retângulo = a*b

            double areaRe = double.Parse(dadosArea[0]) * double.Parse(dadosArea[1]);


            Console.WriteLine($"TRIANGULO: {areaTri:f3}\n" +
                $"CIRCULO: {areaCir:f3}\n" +
                $"TRAPEZIO: {areaTra:f3}\n" +
                $"QUADRADO: {areaQua:f3}\n" +
                $"RETANGULO: {areaRe:f3}");


        }



        


    }
}