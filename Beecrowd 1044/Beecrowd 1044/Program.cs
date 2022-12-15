using System;

namespace Beecrowd_1044
{

    class Program
    {
        static void Main(string[] args)
        {

             string[] valores = Console.ReadLine().Split(' ');

             int valor1 = int.Parse(valores[0]);
             int valor2 = int.Parse(valores[1]);

             int multiplos = valor2 % valor1;
             int multiplos2 = valor1 % valor2;

            if (multiplos % 2 == 0 && multiplos2 % 2 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if (multiplos != 0 && multiplos2 != 0 )
            {
                Console.WriteLine("Nao sao Multiplos");

            }

            

           
            

            
        }
    }
}