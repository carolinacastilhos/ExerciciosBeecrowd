using System;

namespace Beecrowd_1118
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int opcao = 1;
            
            while (opcao != 2)
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
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());

                for (; opcao != 1 && opcao != 2;)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                }

                if (opcao == 2)
                {
                    break;
                }

                
                
            }
            

                       

        }
    }
}