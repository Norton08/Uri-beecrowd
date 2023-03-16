//https://www.beecrowd.com.br/repository/UOJ_1073.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1073_Quadrado_de_Pares
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 2; i <= N; i += 2)
            {
                Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
            }
        }
    }
}
