using System;

namespace Beecrowd_1047
{
    class Program
    {
        static void Main(string[] args)
        {

             string[] valoresJogo = Console.ReadLine().Split(' ');

             int horaInicialJogo = int.Parse(valoresJogo[0]);
             int minutoInicialJogo = int.Parse(valoresJogo[1]);
             int horaFinalJogo = int.Parse(valoresJogo[2]);
             int minutoFinalJogo = int.Parse(valoresJogo[3]);

            int tempoInicialJogoEmMinutos = (horaInicialJogo * 60) + minutoInicialJogo;
            int tempoFinalJogoEmMinutos = (horaFinalJogo * 60) + minutoFinalJogo;

             if (tempoFinalJogoEmMinutos > tempoInicialJogoEmMinutos)
             {
                int duracaoJogo = tempoFinalJogoEmMinutos - tempoInicialJogoEmMinutos;
                int horas = duracaoJogo / 60;
                int minutos = duracaoJogo % 60;
                Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
             }
             else if (tempoFinalJogoEmMinutos < tempoInicialJogoEmMinutos)
             {
                int duracaoJogo2 = (1440 - tempoInicialJogoEmMinutos) + tempoFinalJogoEmMinutos;
                int horas2 = duracaoJogo2/ 60;
                int minutos2 = duracaoJogo2 % 60;
                Console.WriteLine($"O JOGO DUROU {horas2} HORA(S) E {minutos2} MINUTO(S)");
             } 
             else
             {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
             }
             

        }
    }
}