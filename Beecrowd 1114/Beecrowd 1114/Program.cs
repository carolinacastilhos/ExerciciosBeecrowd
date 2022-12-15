using System;

namespace Beecrowd_1114
{
    public class Program
    {
        public static void Main(string[] args)
        {
           int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) 
            {
                Console.WriteLine("Senha Invalida");

                senha = int.Parse(Console.ReadLine());

                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                }
                                 
            }
            




        }
    }
}
