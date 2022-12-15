using System;

namespace Beecrowd_1070
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                int numeroInicio = valor + 1;
                int controle = valor + 12;
               
                for (int i = numeroInicio; i <= controle; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else if (valor % 2 != 0)
            {
                int controle = valor + 11;

                for (int i = valor ; i <= controle; i += 2)
                {
                    Console.WriteLine(i);
                }
            } 
            


        }
    }
}
