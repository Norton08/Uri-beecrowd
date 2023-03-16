//https://www.beecrowd.com.br/repository/UOJ_1132.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1132_Múltiplos_de_13
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

            int soma = 0;

            for (int i = menor; i <= maior; i++)
            {
                if(!(i % 13 == 0))
                    soma += i;
            }
            Console.WriteLine($"{soma}");
        }
    }
}
