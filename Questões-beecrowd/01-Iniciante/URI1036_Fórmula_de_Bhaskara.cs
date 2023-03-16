//https://www.beecrowd.com.br/repository/UOJ_1036.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1036_Fórmula_de_Bhaskara
    {
        public static void Run()
        {
            double A, B, C, R1, R2, delta, raizDelta;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            delta = Math.Pow(B, 2) - 4 * A * C;
            raizDelta = Math.Sqrt(delta);

            R1 = (-B + raizDelta) / (2 * A);
            R2 = (-B - raizDelta) / (2 * A);

            if (delta < 0.0 || A == 0)
                Console.WriteLine("Impossivel calcular");

            else
            {
                Console.WriteLine($"R1 = {R1.ToString("0.00000", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {R2.ToString("0.00000", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
