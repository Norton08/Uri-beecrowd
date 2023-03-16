//https://www.beecrowd.com.br/repository/UOJ_1014.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1014_Consumo
    {
        public static void Run()
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine((x / y).ToString("0.000") + " km/l");
        }
    }
}
