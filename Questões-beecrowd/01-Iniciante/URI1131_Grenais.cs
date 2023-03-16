//https://www.beecrowd.com.br/repository/UOJ_1131.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1131_Grenais
    {
        public static void Run()
        {
            int sair = 0, grenal = 0, golsInter = 0, golsGremio = 0, vitInter = 0, vitGremio = 0, empate = 0;

            while (sair != 2)
            {
                string[] vect = Console.ReadLine().Split(' ');

                golsInter = int.Parse(vect[0]);
                golsGremio = int.Parse(vect[1]);

                if (golsInter > golsGremio)
                    vitInter++;
                else if (golsInter < golsGremio)
                    vitGremio++;
                else if (golsInter == golsGremio)
                    empate++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                sair = int.Parse(Console.ReadLine());
                grenal++;

            }
            string[] str = new string[2] {
            "Inter",
            "Gremio",
            };
            int c = 0;

            Console.WriteLine($"{grenal} grenais");
            Console.WriteLine($"Inter:{vitInter}");
            Console.WriteLine($"Gremio:{vitGremio}");
            Console.WriteLine($"Empates:{empate}");

            if (vitInter < vitGremio)
                c += 1;

            Console.WriteLine($"{str[c]} venceu mais");
        }
    }
}
