//https://www.beecrowd.com.br/repository/UOJ_1080.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1080_Maior_e_Posição
    {
        public static void Run()
        {
            int[] vect = new int[101];

            for(int i = 1 ; i <= 100 ; i++)
            {
                int a = int.Parse(Console.ReadLine());

                vect[i] = a;
            }

            int maior = 0,index = 0;

            for (int k = 1; k <= 100; k++)
            {
                if (maior < vect[k])
                {
                    maior = vect[k];
                    index = k;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(index);
        }
    }
}
