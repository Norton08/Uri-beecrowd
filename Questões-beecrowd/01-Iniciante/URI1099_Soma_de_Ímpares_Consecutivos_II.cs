//https://www.beecrowd.com.br/repository/UOJ_1099.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1099_Soma_de_Ímpares_Consecutivos_II
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');

                int X = int.Parse(vect[0]);
                int Y = int.Parse(vect[1]);
                int soma = 0;

                if (X > Y)
                {
                    int aux = X;
                    X = Y;
                    Y = aux;
                }

                for (int j = X + 1; j > X && j < Y; j++)
                {
                    if (j % 2 != 0)
                        soma += j;
                }

                Console.WriteLine(soma);
            }
        }
    }
}
