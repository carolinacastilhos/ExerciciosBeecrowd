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















            /*double total1 = quantLanche * 4.0;
            double total2 = quantLanche * 4.50;
            double total3 = quantLanche * 5.00;
            double total4 = quantLanche * 2.00;
            double total5 = quantLanche * 1.50;



            if (codigoLanche == 1)
            {
                Console.WriteLine($"Total: R$ {total1:f2}");

            }
            else if (codigoLanche == 2)
            {
                Console.WriteLine($"Total: R$ {total2:f2}");
            }
            else if (codigoLanche == 3)
            {
                Console.WriteLine($"Total: R$ {total3:f2}");
            }
            else if (codigoLanche == 4)
            {
                Console.WriteLine($"Total: R$ {total4:f2}");
            }
            else (codigoLanche == 5) 
            {
                Console.WriteLine($"Total: R$ {total5:f2}");

            }

            */






        }
    }
}