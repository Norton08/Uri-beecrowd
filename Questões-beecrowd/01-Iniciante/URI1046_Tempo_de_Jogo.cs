//https://www.beecrowd.com.br/repository/UOJ_1046.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1046_Tempo_de_Jogo
    {
        public static void Run()
        {
            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a == b)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if (a > b)
            {
                Console.WriteLine($"O JOGO DUROU {(24 - a) + b} HORA(S)");
            }
            else if (a < b)
            {
                Console.WriteLine($"O JOGO DUROU {b - a} HORA(S)");
            }
        }
    }
}
