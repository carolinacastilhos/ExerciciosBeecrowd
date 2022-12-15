using System;

namespace Beecrowd_1099
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int valorQuantidadeDeTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < valorQuantidadeDeTestes; i++)
            {
                string[] testes = Console.ReadLine().Split(' ');

                int teste1 = int.Parse(testes[0]);
                int teste2 = int.Parse(testes[1]);

                int maior, menor;
                int somaÍmpares = 0;

                if (teste1 < teste2)
                {
                    menor = teste1;
                    maior = teste2;
                }
                else
                {
                    maior = teste1;
                    menor = teste2;

                }
                for (int numero = menor + 1; numero < maior; numero ++)
                {
                    if (numero % 2 != 0)
                    {
                        somaÍmpares += numero;
                    }
                    

                }

                Console.WriteLine(somaÍmpares);
            }

        }    
        
    }
}