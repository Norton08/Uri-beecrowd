//https://www.beecrowd.com.br/repository/UOJ_1142.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1142_PUM
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            int i = 1, j = 2, k = 3;

            while(N-- != 0)
            {
                Console.WriteLine($"{i} {j} {k} PUM");

                i += 4;
                j += 4;
                k += 4;
            }
        }
    }
}
