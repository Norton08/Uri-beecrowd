//https://www.beecrowd.com.br/repository/UOJ_1002.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1002_Área_do_Círculo
    {
        public static void Run()
        {
            double pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * (raio * raio);
            Console.WriteLine("A=" 
                        + Math.Round(area, 4, MidpointRounding.AwayFromZero)
                                .ToString("0.0000", CultureInfo.InvariantCulture));
        }
    }
}
