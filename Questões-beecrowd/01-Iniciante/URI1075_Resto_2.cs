//https://www.beecrowd.com.br/repository/UOJ_1075.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1075_Resto_2
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10000;i++)
            {
                if(i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
