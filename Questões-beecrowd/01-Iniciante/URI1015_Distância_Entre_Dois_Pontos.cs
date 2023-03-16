//https://www.beecrowd.com.br/repository/UOJ_1015.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1015_Distância_Entre_Dois_Pontos
    {
        public static void Run()
        {
            double x1, y1, x2, y2;

            string[] vet1 = Console.ReadLine()
                                   .Split(' ');
            x1 = double.Parse(vet1[0]);
            y1 = double.Parse(vet1[1]);

            string[] vet2 = Console.ReadLine()
                                   .Split(' ');
            x2 = double.Parse(vet2[0]);
            y2 = double.Parse(vet2[1]);

            Console.WriteLine((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)))
                          .ToString("0.0000"), CultureInfo.InvariantCulture);
        }
    }
}
