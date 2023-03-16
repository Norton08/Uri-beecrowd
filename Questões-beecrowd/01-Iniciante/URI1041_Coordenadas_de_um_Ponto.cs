//https://www.beecrowd.com.br/repository/UOJ_1041.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1041_Coordenadas_de_um_Ponto
    {
        public static void Run()
        {
            string[] str = new string[7] {
            "Origem",
            "Q1",
            "Q2",
            "Q3",
            "Q4",
            "Eixo Y",
            "Eixo X",
            };

            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);
            int disp = 0;

            if (x == 0 && y == 0)
                disp += 0;
            else if (x > 0 && y > 0)
                disp += 1;
            else if (x < 0 && y > 0)
                disp += 2;
            else if (x < 0 && y < 0)
                disp += 3;
            else if (x > 0 && y < 0)
                disp += 4;
            else if (x == 0 && y != 0)
                disp += 5;
            else if (x != 0 && y == 0)
                disp += 6;

            Console.WriteLine($"{str[disp]}");
        }
    }
}
