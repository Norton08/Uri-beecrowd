//https://www.beecrowd.com.br/repository/UOJ_1047.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1047_Tempo_de_Jogo_com_Minutos
    {
        public static void Run()
        {
            string[] vet = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vet[0]);
            int minutoInicial = int.Parse(vet[1]);
            int horaFinal = int.Parse(vet[2]);
            int minutoFinal = int.Parse(vet[3]);

            int momentoInicial = (horaInicial * 60) + minutoInicial;
            int momentoFinal = (horaFinal * 60) + minutoFinal;

            if (momentoInicial == momentoFinal)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (momentoInicial > momentoFinal)
            {
                Console.WriteLine($"O JOGO DUROU {(1440 - (momentoInicial - momentoFinal)) / 60} HORA(S) E {(1440 - (momentoInicial - momentoFinal)) % 60} MINUTO(S)");
            }
            else if (momentoInicial < momentoFinal)
            {
                Console.WriteLine($"O JOGO DUROU {(momentoFinal - momentoInicial) / 60} HORA(S) E {(momentoFinal - momentoInicial) % 60} MINUTO(S)");
            }
        }
    }
}
