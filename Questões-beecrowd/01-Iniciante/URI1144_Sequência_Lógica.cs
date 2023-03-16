//https://www.beecrowd.com.br/repository/UOJ_1144.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1144_Sequência_Lógica
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
                Console.WriteLine($"{i} {Math.Pow(i, 2) + 1} {Math.Pow(i, 3) +1}");
            }
        }
    }
}
