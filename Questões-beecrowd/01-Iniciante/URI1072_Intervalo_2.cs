//https://www.beecrowd.com.br/repository/UOJ_1072.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1072_Intervalo_2
    {
        public static void Run()
        {
            int dentro = 0;
            int fora = 0;

            int N = int.Parse(Console.ReadLine());

            while (N-- != 0)
            {
                int comp = int.Parse(Console.ReadLine());

                if (comp >= 10 && comp <= 20) dentro++;
                else fora++;
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
