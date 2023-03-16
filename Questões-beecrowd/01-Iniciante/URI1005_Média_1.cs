//https://www.beecrowd.com.br/repository/UOJ_1005.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1005_Média_1
    {
        public static void Run()
        {
            double x = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("MEDIA = " + ((3.5 * x + 7.5 * y) / 11).ToString("0.00000", CultureInfo.InvariantCulture));
        }
    }
}
