using System;
using System.Net.Http.Headers;

namespace Beecrowd_1117
{
    public class Program
    {

        public static void Main(string[] args)
        {

            double soma = 0;
            int controle = 0;
           
            for (int i = 0; controle < 2; i++)
            {
                double nota = double.Parse(Console.ReadLine());                      

                if (nota >= 0 && nota <= 10)
                {
                    soma += nota;
                    controle++;
                   
                }
                else 
                {
                    Console.WriteLine("nota invalida");
                }

                
            }

            double mediaSemestral = soma / 2;
            Console.WriteLine($"media = {mediaSemestral:f2}");







        }

    }
}
