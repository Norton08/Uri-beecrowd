//https://www.beecrowd.com.br/repository/UOJ_1118.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1118_Várias_Notas_Com_Validação
    {
        public static void Run()
        {
            int sair = 0;
            while(sair != 2)
            {
                sair = 0;
                double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (X < 0 || X > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (Y < 0 || Y > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                Console.WriteLine($"media = {(X + Y) / 2:0.00}");

                while(sair != 1 && sair != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    sair = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
