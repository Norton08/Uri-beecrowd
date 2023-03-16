//https://www.beecrowd.com.br/repository/UOJ_1095.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1095_Sequência_IJ_1
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
        }
    }
}
