//https://www.beecrowd.com.br/repository/UOJ_1146.html
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Questões_beecrowd.Iniciante
{
    public class URI1146_Sequências_Crescentes
    {
        public static void Run()
        {
            int N;
            do
            {
                N = int.Parse(Console.ReadLine());

                for (int i = 1; i <= N; i++)
                {
                    if (i < N)
                    {
                        Console.Write("{0} ", i);
                    }
                    else
                    {
                        Console.Write("{0}\n", i);
                    }

                }

            } 
            while (N != 0);
        }
    }
}
