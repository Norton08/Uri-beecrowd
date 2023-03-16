//https://www.beecrowd.com.br/repository/UOJ_1074.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1074_Par_ou_Ímpar
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            while(N-- != 0)
            {
                int X = int.Parse(Console.ReadLine());

                if (X % 2 == 0 && X > 0) Console.WriteLine("EVEN POSITIVE");
                if (X % 2 == 0 && X < 0) Console.WriteLine("EVEN NEGATIVE");
                else if (X % 2 != 0 && X > 0) Console.WriteLine("ODD POSITIVE");
                else if (X % 2 != 0 && X < 0) Console.WriteLine("ODD NEGATIVE");
                else if (X == 0) Console.WriteLine("NULL");
            }
        }
    }
}
