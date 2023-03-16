//https://www.beecrowd.com.br/repository/UOJ_1065.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1065_Pares_entre_Cinco_Números
    {
        public static void Run()
        {
            int numPares = 0;
            for (int i = 0; i < 5; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num % 2 == 0.0)
                {
                    numPares++;
                }

            }
            Console.WriteLine($"{numPares} valores pares");
        }
    }
}
