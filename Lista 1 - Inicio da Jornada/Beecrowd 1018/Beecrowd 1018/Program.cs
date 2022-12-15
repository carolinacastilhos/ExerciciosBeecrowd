using System;

namespace Beecrowd_1018
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = int.Parse(Console.ReadLine());

            int nota1, quantnota1, nota2, quantnota2, restante2, nota5, quantnota5, restante5, nota10, quantnota10, restante10, nota20, quantnota20, restante20, nota50, quantnota50, restante50, nota100, quantnota100, restante100;

            nota100 = 100;
            quantnota100 = valor / nota100;
            restante100 = valor % nota100;

            nota50 = 50;
            quantnota50 = restante100 / nota50;
            restante50 = restante100 % nota50; 

            nota20 = 20;
            quantnota20 = restante50 / nota20;
            restante20 = restante50 % nota20;

            nota10 = 10;
            quantnota10 = restante20 / nota10;
            restante10 = restante20 % nota10;

            nota5 = 5;
            quantnota5 = restante10 / nota5;
            restante5 = restante10 % nota5;

            nota2 = 2;
            quantnota2 = restante5 / nota2;
            restante2 = restante5 % nota2;

            nota1 = 1;
            quantnota1 = restante2 / nota1;
            


            Console.WriteLine($"{valor}\n" +
                $"{quantnota100} nota(s) de R$ 100,00\n" +
                $"{quantnota50} nota(s) de R$ 50,00\n" +
                $"{quantnota20} nota(s) de R$ 20,00\n" +
                $"{quantnota10} nota(s) de R$ 10,00\n" +
                $"{quantnota5} nota(s) de R$ 5,00\n" +
                $"{quantnota2} nota(s) de R$ 2,00\n" +
                $"{quantnota1} nota(s) de R$ 1,00");


        }
    }
}
