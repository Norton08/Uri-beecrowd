//https://www.beecrowd.com.br/repository/UOJ_1021.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1021_Notas_e_Moedas
    {
        public static void Run()
        {
            double N = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] notas = new double[6] { 100.0, 50.0, 20.0, 10.0, 5.0, 2.0 };
            double[] moedas = new double[6] { 1.0, 0.5, 0.25, 0.1, 0.05, 0.01 };
            string[] str = new string[2] { "nota(s) de R$", "moeda(s) de R$" };

            Console.WriteLine("NOTAS:");

            for (int i = 0; i < notas.Length; i++)
            {
                var qtdNotas = N / notas[i];
                Console.WriteLine($"{Math.Floor(qtdNotas)} {str[0]} {notas[i]:0.00}");
                N %= notas[i];
            }

            Console.WriteLine("MOEDAS:");
            for (int i = 0; i < moedas.Length; i++)
            {
                var qtdMoedas = N / moedas[i];
                Console.WriteLine($"{Math.Floor(qtdMoedas)} {str[1]} {moedas[i]:0.00}");
                N = (N % moedas[i]) + 0.00001;
            }

        }
    }
}
