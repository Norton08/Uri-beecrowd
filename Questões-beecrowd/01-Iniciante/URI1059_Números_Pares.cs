//https://www.beecrowd.com.br/repository/UOJ_1059.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1059_Números_Pares
    {
        public static void Run()
        {
            for(int i = 1 ; i <= 100 ; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
