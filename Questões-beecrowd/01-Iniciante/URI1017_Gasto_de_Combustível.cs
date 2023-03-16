//https://www.beecrowd.com.br/repository/UOJ_1017.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1017_Gasto_de_Combustível
    {
        public static void Run()
        {
            double carro = 12.0;

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(((x * y) / carro).ToString("0.000"));
        }
    }
}
