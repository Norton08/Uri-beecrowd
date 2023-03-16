//https://www.beecrowd.com.br/repository/UOJ_1113.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1113_Crescente_e_Decrescente
    {
        public static void Run()
        {
            string[] vect = Console.ReadLine().Split(' ');

            int M = int.Parse(vect[0]);
            int N = int.Parse(vect[1]);

            while (!(M == N))
            {
                if(M > N)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

                vect = Console.ReadLine().Split(' ');

                M = int.Parse(vect[0]);
                N = int.Parse(vect[1]);
            }
        }
    }
}
