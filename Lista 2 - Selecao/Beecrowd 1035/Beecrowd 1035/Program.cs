using System;

namespace Selection_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');

            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int n3 = int.Parse(numeros[2]);
            int n4 = int.Parse(numeros[3]);

            int soma1 = n3 + n4;
            int soma2 = n1 + n2;

            if (n2 > n3 && n4 > n1 && soma1 > soma2 && n3>0 && n4>0 && n1%2==0 )
            {
                Console.WriteLine($"Valores aceitos");

            }
            else Console.WriteLine($"Valores nao aceitos");
            
            
         
           


        }
    }
}
