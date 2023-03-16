//https://www.beecrowd.com.br/repository/UOJ_1007.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1007_Diferença
    {
        public static void Run()
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DIFERENCA = " + (a * b - c * d));
        }
    }
}
