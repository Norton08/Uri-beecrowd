//https://www.beecrowd.com.br/repository/UOJ_1101.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1101_Sequência_de_Números_e_Soma
    {
        public static void Run()
        {
            string[] vect = Console.ReadLine().Split(' ');

            int M = int.Parse(vect[0]);
            int N = int.Parse(vect[1]);

            while (M > 0 && N > 0)
            {
                int menor = M;
                int maior = N;

                if (M > N)
                {
                    menor = N;
                    maior = M;
                }

                int soma = 0;
                for (int i = menor; i <= maior; i++)
                {
                    soma += i;
                    Console.Write($"{i} ");
                }
                Console.WriteLine($"Sum={soma}");

                vect = Console.ReadLine().Split(' ');

                M = int.Parse(vect[0]);
                N = int.Parse(vect[1]);
            }
        }
    }
}
