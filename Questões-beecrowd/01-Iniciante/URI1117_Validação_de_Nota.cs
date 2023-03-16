//https://www.beecrowd.com.br/repository/UOJ_1117.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1117_Validação_de_Nota
    {
        public static void Run()
        {
            double X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            while(X < 0 || X > 10.0)
            {
                Console.WriteLine("nota invalida");
                X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (Y < 0 || Y > 10.0)
            {
                Console.WriteLine("nota invalida");
                Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine($"media = {(X+Y)/2:0.00}");
        }
    }
}
