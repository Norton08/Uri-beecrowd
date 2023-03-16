//https://www.beecrowd.com.br/repository/UOJ_1143.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1143_Quadrado_e_ao_Cubo
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}");
            }
        }
    }
}
