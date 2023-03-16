//https://www.beecrowd.com.br/repository/UOJ_1006.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1006_Média_2
    {
        public static void Run()
        {
            double x = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double z = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("MEDIA = " + ((2 * x + 3 * y + 5 * z) / 10).ToString("0.0", CultureInfo.InvariantCulture));

        }
    }
}
