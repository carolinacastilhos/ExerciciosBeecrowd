using System;

namespace Beecrowd_1051
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine());

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000)
            {
                double impostoRenda1 = (salario - 2000) * 0.08;
                Console.WriteLine($"R$ {impostoRenda1:f2}");
            }
            else if (salario <= 4500)
            {
                double taxa1 = (salario - 3000) * 0.18;
                double taxa2 = 1000 * 0.08;
                double impostoRenda2 = taxa1 + taxa2;
                Console.WriteLine($"R$ {impostoRenda2:f2}");
            }
            else
            {
                double taxa3 = (salario - 4500) * 0.28;
                double taxa4 = 1500 * 0.18;
                double taxa5 = 1000 * 0.08;
                double impostoRenda3 = taxa3 + taxa4 + taxa5;
                Console.WriteLine($"R$ {impostoRenda3:f2}");

            }





            
            
            
            





        }
    }
}