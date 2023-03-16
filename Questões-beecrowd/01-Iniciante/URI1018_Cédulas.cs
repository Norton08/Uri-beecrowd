//https://www.beecrowd.com.br/repository/UOJ_1018.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1018_Cédulas
    {
        public static void Run()
        {
            double N = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] notas = new double[7] { 100.0, 50.0, 20.0, 10.0, 5.0, 2.0, 1.0 };
            string[] str = new string[1] { "nota(s) de" };

            Console.WriteLine(N);

            for (int i = 0; i < notas.Length; i++)
            {
                var qtdNotas = N / notas[i];
                Console.WriteLine($"{Math.Floor(qtdNotas)} {str[0]} {notas[i].ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
                N %= notas[i];
            }
        }
    }
}
