using System;

namespace Beecrowd_1038
{

    class Program
    {

        static void Main(string[] args)
        {

            string[] lanche = Console.ReadLine().Split(' ');

            int codigoLanche = int.Parse(lanche[0]);
            int quantLanche = int.Parse(lanche[1]);

            double valor = 0;


            if (codigoLanche == 1)
            {
                valor = 4.00;
            }
            else if (codigoLanche == 2)
            {
                valor = 4.50;
            }
            else if (codigoLanche == 3)
            {
                valor = 5.00;
            }
            else if (codigoLanche == 4)
            {
                valor = 2.00;
            }
            else if (codigoLanche == 5)
            {
                valor = 1.50;
            }

            double total = valor * quantLanche;

            Console.WriteLine($"Total: R$ {total:f2}");




        }
    }
}