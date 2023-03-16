//https://www.beecrowd.com.br/repository/UOJ_1009.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1009_Salário_com_Bônus
    {
        public static void Run()
        {
            string x = Console.ReadLine();
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("TOTAL = R$ " + (y + 0.15 * z).ToString("0.00"), CultureInfo.InvariantCulture);

        }
    }
}
