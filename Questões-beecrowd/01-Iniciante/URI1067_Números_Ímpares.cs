//https://www.beecrowd.com.br/repository/UOJ_1067.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1067_Números_Ímpares
    {
        public static void Run()
        {
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
        }
    }
}
