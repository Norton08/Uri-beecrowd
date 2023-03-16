//https://www.beecrowd.com.br/repository/UOJ_1064.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1064_Positivos_e_Média
    {
        public static void Run()
        {
            int numPositivo = 0;
            double media = 0;
            for (int i = 0; i < 6; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num > 0.0)
                {
                    numPositivo++;
                    media += num;
                }

            }
            Console.WriteLine($"{numPositivo} valores positivos");
            Console.WriteLine($"{(media / numPositivo):0.0}");
        }
    }
}
