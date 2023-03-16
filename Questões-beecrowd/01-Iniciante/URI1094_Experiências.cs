//https://www.beecrowd.com.br/repository/UOJ_1094.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1094_Experiências
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            float cobaias = 0, coelhos = 0, ratos = 0, sapos = 0;
            for(int i = 0; i < N; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');

                cobaias += float.Parse(vect[0]);
                float caracter = char.Parse(vect[1]);

                if(caracter == 'C')
                {
                    coelhos += float.Parse(vect[0]);
                }
                else if(caracter == 'R')
                {
                    ratos += float.Parse(vect[0]);

                }
                else if(caracter == 'S')
                {
                    sapos += float.Parse(vect[0]);
                }

            }
            Console.WriteLine($"Total: {cobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {(coelhos/cobaias) * 100:0.00} %");
            Console.WriteLine($"Percentual de ratos: {(ratos / cobaias) * 100:0.00} %");
            Console.WriteLine($"Percentual de sapos: {(sapos / cobaias) * 100:0.00} %");
        }
    }
}
