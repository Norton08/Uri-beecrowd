//https://www.beecrowd.com.br/repository/UOJ_1079.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1079_Médias_Ponderadas
    {
        public static void Run()
        {
            double x = double.Parse(Console.ReadLine());

            while (x != 0)
            {
                double a, b, c, valor;
                string[] vet1 = Console.ReadLine().Split(' ');

                a = double.Parse(vet1[0]);
                b = double.Parse(vet1[1]);
                c = double.Parse(vet1[2]);

                valor = (2 * a + 3 * b + 5 * c) / 10;
                Console.WriteLine($"{valor:0.0}");
                x--;
            }
        }
    }
}
