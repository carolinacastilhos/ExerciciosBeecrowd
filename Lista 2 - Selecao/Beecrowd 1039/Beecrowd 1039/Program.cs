using System;

namespace Beecrowd_1040
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] notasAluno = Console.ReadLine().Split(' ');

            double nota1 = double.Parse(notasAluno[0]);
            double nota2 = double.Parse(notasAluno[1]);
            double nota3 = double.Parse(notasAluno[2]);
            double nota4 = double.Parse(notasAluno[3]);

            double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / (10);
            media = Math.Truncate(100*media)/100;

            Console.WriteLine($"Media: {media:f1}");

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                double notaAlunoExame = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"Nota do exame: {notaAlunoExame:f1}");

                double mediaFinal = (media + notaAlunoExame)/2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine($"Aluno aprovado.\n" +
                        $"Media final: {mediaFinal:f1}");
                }
                else if (mediaFinal <= 4.9)
                {
                    Console.WriteLine($"Aluno reprovado.\n" +
                        $"Media final: {mediaFinal:f1}");
                }




            }



        }
    }
}
