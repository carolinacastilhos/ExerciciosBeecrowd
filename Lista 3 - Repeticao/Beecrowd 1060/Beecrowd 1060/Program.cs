using System;

namespace Beecrowd_1060
{
    public class Progdram
    {
        public static void Main(string[] args)
        {

            double[] valores = new double[6];

            valores[0] = double.Parse(Console.ReadLine());
            valores[1] = double.Parse(Console.ReadLine());
            valores[2] = double.Parse(Console.ReadLine());
            valores[3] = double.Parse(Console.ReadLine());
            valores[4] = double.Parse(Console.ReadLine());
            valores[5] = double.Parse(Console.ReadLine());


            int totalPositivos = 0;

            foreach (double positivo in valores)
            {
                if (positivo > 0)
                {
                    totalPositivos = totalPositivos + 1;

                }

                
            }

            Console.WriteLine($"{totalPositivos} valores positivos");

        }


    }

}         
                    


                   


                



            

            

            


        
    
