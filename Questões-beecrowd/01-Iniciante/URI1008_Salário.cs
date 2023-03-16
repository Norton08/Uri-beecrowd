//https://www.beecrowd.com.br/repository/UOJ_1008.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1008_Salário
    {
        public static void Run()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("NUMBER = " + x);
            Console.WriteLine("SALARY = U$ " + (y * z).ToString("0.00"), CultureInfo.InvariantCulture);
        }
    }
}
