//https://www.beecrowd.com.br/repository/UOJ_1051.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1051_Imposto_de_Renda
    {
        public static void Run()
        {
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if(renda > 2000.00 && renda <= 3000.00)
            {
                renda -= 2000.00;
                renda = 8 * renda / 100.00;
                Console.WriteLine($"R$ {renda:0.00}");
            }
            else if (renda > 3000.00 && renda <= 4500.00)
            {
                renda -= 3000.00;
                renda = 8 * 10 + (18 * renda / 100.00);
                Console.WriteLine($"R$ {renda:0.00}");
            }
            else
            {
                renda -= 4500.00;
                renda = 8 * 10 + 18 * 15 + (28 * renda / 100.00);
                Console.WriteLine($"R$ {renda:0.00}");
            }
        }
    }
}
