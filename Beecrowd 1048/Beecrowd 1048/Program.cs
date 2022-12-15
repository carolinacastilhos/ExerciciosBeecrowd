using System;

namespace Beecrowd_1048
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salarioFuncionario = double.Parse(Console.ReadLine());
            
            if (salarioFuncionario <= 400.00)
            {
                double reajusteGanho1 = salarioFuncionario * 0.15;
                double novoSalario1 = salarioFuncionario + reajusteGanho1;
                Console.WriteLine($"Novo salario: {novoSalario1:f2}\n" +
                    $"Reajuste ganho: {reajusteGanho1:f2}\n" +
                    $"Em percentual: 15 %");
            }
            else if (salarioFuncionario <= 800.00)
            {
                double reajusteGanho2 = salarioFuncionario * 0.12;
                double novoSalario2 = salarioFuncionario + reajusteGanho2;
                Console.WriteLine($"Novo salario: {novoSalario2:f2}\n" +
                    $"Reajuste ganho: {reajusteGanho2:f2}\n" +
                    $"Em percentual: 12 %");
            }
            else if (salarioFuncionario <= 1200.00)
            {
                double reajusteGanho3 = salarioFuncionario * 0.10;
                double novoSalario3 = salarioFuncionario + reajusteGanho3;
                Console.WriteLine($"Novo salario: {novoSalario3:f2}\n" +
                    $"Reajuste ganho: {reajusteGanho3:f2}\n" +
                    $"Em percentual: 10 %");
            }
            else if (salarioFuncionario <= 2000.00)
            {
                double reajusteGanho4 = salarioFuncionario * 0.07;
                double novoSalario4 = salarioFuncionario + reajusteGanho4;
                Console.WriteLine($"Novo salario: {novoSalario4:f2}\n" +
                    $"Reajuste ganho: {reajusteGanho4:f2}\n" +
                    $"Em percentual: 7 %");
            }
            else
            {
                double reajusteGanho5 = salarioFuncionario * 0.04;
                double novoSalario5 = salarioFuncionario + reajusteGanho5;
                Console.WriteLine($"Novo salario: {novoSalario5:f2}\n" +
                    $"Reajuste ganho: {reajusteGanho5:f2}\n" +
                    $"Em percentual: 4 %");
            }
        }
    }
}
