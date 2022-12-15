using System;

namespace Beecrowd_1094
{
    public class Program
    {
        public static void Main(string[] args)
        {


            int valorQuantidadeTestes = int.Parse(Console.ReadLine());

            int somaCoelhos = 0;
            int somaRatos = 0;
            int somaSapos = 0;

            
            for (int i = 1; i <= valorQuantidadeTestes; i++)
            {
                string[] teste = Console.ReadLine().Split(' ');
                int quantidaDeCobaias = int.Parse(teste[0]);
                char tipoDeCobaia = char.Parse(teste[1]);  // C= coelho, R = rato, S = sapo

                
                if (tipoDeCobaia == 'C')
                {
                    somaCoelhos += quantidaDeCobaias;               
                }
                else if (tipoDeCobaia == 'R')
                {
                    somaRatos += quantidaDeCobaias;
                }
                else if (tipoDeCobaia == 'S')
                {
                    somaSapos += quantidaDeCobaias;
                }


            }


            int totalCobaias = somaCoelhos + somaRatos + somaSapos;
            double percentualCoelhos = somaCoelhos * 100.00 / totalCobaias;
            double percentualRatos = somaRatos * 100.00 / totalCobaias;
            double percentualSapos = somaSapos * 100.00 / totalCobaias;


            Console.WriteLine($"Total: {totalCobaias} cobaias\n" +
                    $"Total de coelhos: {somaCoelhos}\n" +
                    $"Total de ratos: {somaRatos}\n" +
                    $"Total de sapos: {somaSapos}\n" +
                    $"Percentual de coelhos: {percentualCoelhos:f2} %\n" +
                    $"Percentual de ratos: {percentualRatos:f2} %\n" +
                    $"Percentual de sapos: {percentualSapos:f2} %");


        }
    }
}