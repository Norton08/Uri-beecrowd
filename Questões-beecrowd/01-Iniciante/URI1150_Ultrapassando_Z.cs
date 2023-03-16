//https://www.beecrowd.com.br/repository/UOJ_1150.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1150_Ultrapassando_Z
    {
        public static void Run()
        {
            int X = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            while(X >= Z)
                Z = int.Parse((Console.ReadLine()));

            int xablau = 0;
            int j = 0;
            for (int i = X; xablau < Z; i++)
            {
                xablau += i;
                j++;
            }

            Console.WriteLine(j);
        }
    }
}
