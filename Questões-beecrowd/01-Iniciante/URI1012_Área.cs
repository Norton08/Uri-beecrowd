//https://www.beecrowd.com.br/repository/UOJ_1012.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1012_Área
    {
        public static void Run()
        {
            double pi = 3.14159;
            double a, b, c;

            string[] vet = Console.ReadLine()
                                  .Split(' ');

            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            Console.WriteLine("TRIANGULO: " + ((a * c) / 2).ToString("0.000"), CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCULO: " + (pi * Math.Pow(c, 2)).ToString("0.000"), CultureInfo.InvariantCulture);
            Console.WriteLine("TRAPEZIO: " + (((a + b) * c) / 2).ToString("0.000"), CultureInfo.InvariantCulture);
            Console.WriteLine("QUADRADO: " + Math.Pow(b, 2).ToString("0.000"), CultureInfo.InvariantCulture);
            Console.WriteLine("RETANGULO: " + (a * b).ToString("0.000"), CultureInfo.InvariantCulture);
        }
    }
}
