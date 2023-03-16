//https://www.beecrowd.com.br/repository/UOJ_1133.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1133_Resto_da_Divisão
    {
        public static void Run()
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int menor = X;
            int maior = Y;

            if (X > Y)
            {
                menor = Y;
                maior = X;
            }

            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                    Console.WriteLine($"{i}");
            }
        }
    }
}
