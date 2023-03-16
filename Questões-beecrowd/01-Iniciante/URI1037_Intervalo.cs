//https://www.beecrowd.com.br/repository/UOJ_1037.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1037_Intervalo
    {
        public static void Run()
        {
            string[] str = new string[4] { "[0,25]", "(25,50]", "(50,75]", "(75,100]" };

            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x >= 0.0 && x <= 25.0)
                Console.WriteLine($"Intervalo {str[0]}");
            else if (x > 25.0 && x <= 50.0)
                Console.WriteLine($"Intervalo {str[1]}");
            else if (x > 50.0 && x <= 75.0)
                Console.WriteLine($"Intervalo {str[2]}");
            else if (x > 75.0 && x <= 100.0)
                Console.WriteLine($"Intervalo {str[3]}");
            else
                Console.WriteLine($"Fora de intervalo");
        }
    }
}
