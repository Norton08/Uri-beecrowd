//https://www.beecrowd.com.br/repository/UOJ_1066.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1066_Pares_Ímpares_Positivos_e_Negativos
    {
        public static void Run()
        {
            int numPares = 0;
            int numImpares = 0;
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i < 5; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (num % 2 == 0.0) numPares++;
                else numImpares++;

                if (num > 0) positivos++;
                else if(num < 0) negativos++;
            }

            Console.WriteLine($"{numPares} valor(es) par(es)");
            Console.WriteLine($"{numImpares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
        }
    }
}
