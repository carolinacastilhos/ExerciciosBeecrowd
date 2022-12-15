using System;

namespace Beecrowd_1067
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int valor = int.Parse(Console.ReadLine());
           

            for (int numerosImpares = 1; numerosImpares <= valor; numerosImpares +=2)
            {
                Console.WriteLine(numerosImpares);                               

            }
            


        }
    }
}