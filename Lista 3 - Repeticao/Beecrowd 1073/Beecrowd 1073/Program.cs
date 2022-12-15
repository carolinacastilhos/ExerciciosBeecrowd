using System; 

namespace Beecrowd_1073
{
    public class Program
    {

        public static void Main(string[] args)
        {

            int numero = int.Parse(Console.ReadLine());
                                  
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    int quadrado = i * i;

                    Console.WriteLine($"{i}^2 = {quadrado}");
                }
            }


            



        }
    }
}