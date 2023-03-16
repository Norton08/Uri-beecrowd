//https://www.beecrowd.com.br/repository/UOJ_1011.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1011_Esfera
    {
        public static void Run()
        {
            double pi = 3.14159;
            double quatroTercos = 4.0 / 3.0;

            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("VOLUME = " + (quatroTercos * pi * Math.Pow(raio, 3))
                   .ToString("0.000"), CultureInfo.InvariantCulture);
        }
    }
}
