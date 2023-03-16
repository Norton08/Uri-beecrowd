//https://www.beecrowd.com.br/repository/UOJ_1096.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1096_Sequência_IJ_2
    {
        public static void Run()
        {
            for (int i = 1; i <= 10; i+=2)
            {
                int N = 7;
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"I={i} J={N--}");
                }
            }
        }
    }
}
