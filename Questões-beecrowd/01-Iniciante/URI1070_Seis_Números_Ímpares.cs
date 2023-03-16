//https://www.beecrowd.com.br/repository/UOJ_1070.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1070_Seis_Números_Ímpares
    {
        public static void Run()
        {
            int num = int.Parse(Console.ReadLine());
            int i = 0;

            if (num % 2 != 0)
            {
                Console.WriteLine(num);
                i++;
            }

            for (; i < 6; i++)
            {
                if (num % 2 == 0) num++;
                else num += 2;

                Console.WriteLine(num);
            }
        }
    }
}
