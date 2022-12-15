using System; 

namespace Beecrowd_1115
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            int coordenada1 = int.Parse(coordenadas[0]);
            int coordenada2 = int.Parse(coordenadas[1]);

            while (coordenada1 != 0 && coordenada2 != 0)
            {
                if (coordenada1 > 0 && coordenada2 > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (coordenada1 < 0 && coordenada2 > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (coordenada1 < 0 && coordenada2 < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (coordenada1 > 0 && coordenada2 < 0)
                {
                    Console.WriteLine("quarto");
                }

                if (coordenada1 == 0 || coordenada2 == 0)
                {
                    break;
                }

                coordenadas = Console.ReadLine().Split(' ');
                coordenada1 = int.Parse(coordenadas[0]);
                coordenada2 = int.Parse(coordenadas[1]);


            }
           
            



        }
    }
}