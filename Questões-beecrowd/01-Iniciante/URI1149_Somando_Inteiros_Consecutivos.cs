//https://www.beecrowd.com.br/repository/UOJ_1149.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1149_Somando_Inteiros_Consecutivos
    {
        public static void Run()
        {
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);

            int N = int.Parse(vet[1]);
            int j = 1;

            while (N <= 0)
            {
                N = int.Parse(vet[j]);
                j++;
            }

            int xablau = 0;
            for (int i = 0; i <= N - 1; i++)
            {
                xablau += A + i;
            }

            Console.WriteLine(xablau);
        }
    }
}
