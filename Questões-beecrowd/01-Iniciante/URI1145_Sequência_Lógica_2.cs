//https://www.beecrowd.com.br/repository/UOJ_1145.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1145_Sequência_Lógica_2
    {
        public static void Run()
        {
            string[] vet = Console.ReadLine().Split(' ');

            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);
            int j = 0;
            for (int i = 1; i <= Y; i++)
            {
                Console.Write($"{i}");
                j++;

                if (j == X)
                {
                    Console.WriteLine();
                    j = 0;
                }
                else
                    Console.Write(" ");
            }
        }
    }
}
