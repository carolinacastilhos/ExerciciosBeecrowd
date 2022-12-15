using System;

namespace Beecrowd_1020
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = int.Parse(Console.ReadLine());

            int ano, quantAno, restoAno, mes, quantMes, restoMes, dia, quantDia;

            ano = 365;
            quantAno = idade / ano;
            restoAno = idade % ano;

            mes = 30;
            quantMes = restoAno / mes;
            restoMes = restoAno % mes;

            dia = 1;
            quantDia = restoMes / dia;


            Console.WriteLine($"{quantAno} ano (s)\n" +
                $"{quantMes} mes (es)\n" +
                $"{quantDia} dia (s)");
        }
    }
}