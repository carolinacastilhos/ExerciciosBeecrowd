using System;

namespace Beecrowd_1131
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int totalGrenais = 0;
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int novoGrenal = 1;
                 
            while (novoGrenal == 1)
            {

                string[] golsGrenal = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(golsGrenal[0]);
                int golsGremio = int.Parse(golsGrenal[1]);
                
                
                totalGrenais += 1;
                    
                    if (golsInter > golsGremio)
                    {
                        vitoriasInter += 1;
                    }
                    else if (golsGremio > golsInter)
                    {
                        vitoriasGremio += 1;
                    }
                    else
                    {
                        empates += 1;
                    }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());

                if (novoGrenal == 2) 
                {
                    break;
                }

            }
               
                Console.WriteLine($"{totalGrenais} grenais\n" +
                        $"Inter:{vitoriasInter}\n" +
                        $"Gremio:{vitoriasGremio}\n" +
                        $"Empates:{empates}");
                
                if (vitoriasInter > vitoriasGremio) 
                {
                    Console.WriteLine("Inter venceu mais");
                }
                else if (vitoriasGremio > vitoriasInter)
                {
                    Console.WriteLine("Gremio venceu mais");
                }
                else
                {
                    Console.WriteLine("Nao houve vencedor");
                }
                         
        
            
            

            

            

        }
    }
}