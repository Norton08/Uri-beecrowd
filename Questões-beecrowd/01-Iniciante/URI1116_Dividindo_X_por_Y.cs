//https://www.beecrowd.com.br/repository/UOJ_1116.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1116_Dividindo_X_por_Y
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            while (N-- != 0)
            {
                string [] vect = Console.ReadLine().Split(' ');

                double X = double.Parse(vect[0]);
                double Y = double.Parse(vect[1]);
                
                if(Y == 0)
                    Console.WriteLine("divisao impossivel");
                else
                    Console.WriteLine($"{X/Y:0.0}");
            }
        }
    }
}
