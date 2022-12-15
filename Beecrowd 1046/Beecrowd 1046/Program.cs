using System;

namespace Beecrowd_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horasDuracaoJogo = Console.ReadLine().Split(' ');

            int horaInicialJogo = int.Parse(horasDuracaoJogo[0]);
            int horaFinalJogo = int.Parse(horasDuracaoJogo[1]);


            if (horaFinalJogo > horaInicialJogo)
            {
                int duracaoJogo = horaFinalJogo - horaInicialJogo;
                Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
            }
            else if (horaFinalJogo < horaInicialJogo)
            {
                int duracaoJogo2 = 24 - horaInicialJogo + horaFinalJogo;
                Console.WriteLine($"O JOGO DUROU {duracaoJogo2} HORA(S)");
            }
            else  
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            


                           

        
        }
    }
}