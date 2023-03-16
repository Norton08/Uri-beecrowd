//https://www.beecrowd.com.br/repository/UOJ_1060.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1060_Números_Positivos
    {
        public static void Run()
        {
            int numpositivo = 0;
            for (int i = 0; i < 6; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(num>0.0)
                    numpositivo++;
            }
            Console.WriteLine($"{numpositivo} valores positivos");
        }
    }
}
