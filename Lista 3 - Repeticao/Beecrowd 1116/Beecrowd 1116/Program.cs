using System;

namespace Beecrowd_1116
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroDeTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDeTestes; i++)
            {
                string[] testes = Console.ReadLine().Split(' ');
                int teste1 = int.Parse(testes[0]);
                int teste2 = int.Parse(testes[1]);

                if (teste2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                   

                }
                else 
                {
                    double resultadoDivisao = (double)teste1 / teste2;

                    Console.WriteLine($"{resultadoDivisao:f1}");

                }


            }


        }
    }
}