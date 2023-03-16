//https://www.beecrowd.com.br/repository/UOJ_1097.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1097_Sequência_IJ_3
    {
        public static void Run()
        {
            int K = 0;

            for (int i = 1; i <= 10; i+= 2)
            {
                int N = 7;

                N += 2 * K;

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"I={i} J={N--}");
                }
                K++;
            }
        }
    }
}
