using System;

namespace Beecrowd_1074
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int numeroPrincipal = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroPrincipal; i++)
            {
                int numeros = int.Parse(Console.ReadLine());
                                
                if (numeros % 2 == 0 && numeros > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (numeros % 2 != 0 && numeros > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (numeros % 2 == 0 && numeros < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (numeros % 2 != 0 && numeros < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (numeros == 0)
                {             
                    Console.WriteLine("NULL");
                }
                          
                
            }




        }
    }
}