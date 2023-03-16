//https://www.beecrowd.com.br/repository/UOJ_1115.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1115_Quadrante
    {
        public static void Run()
        {
            string[] str = new string[4] {
            "primeiro",
            "segundo",
            "terceiro",
            "quarto",
            };

            int disp = 0;

            string[] vect = Console.ReadLine().Split(' ');

            int X = int.Parse(vect[0]);
            int Y = int.Parse(vect[1]);

            while(X != 0 && Y != 0)
            {
                if (X < 0 && Y > 0)
                    disp += 1;
                else if (X < 0 && Y < 0)
                    disp += 2;
                else if (X > 0 && Y < 0)
                    disp += 3;

                Console.WriteLine($"{str[disp]}");

                vect = Console.ReadLine().Split(' ');

                X = int.Parse(vect[0]);
                Y = int.Parse(vect[1]);

                disp = 0;
            }
        }
    }
}
