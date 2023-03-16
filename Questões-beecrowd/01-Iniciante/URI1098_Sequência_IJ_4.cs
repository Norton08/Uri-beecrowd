//https://www.beecrowd.com.br/repository/UOJ_1098.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1098_Sequência_IJ_4
    {
        public static void Run()
        {
            for (double i = 0; i < 2; i+=0.2)
            {
                for (double j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"I={i.ToString("0.#")} J={(j + i).ToString("0.#")}");
                }
            }
        }
    }
}
