//https://www.beecrowd.com.br/repository/UOJ_1040.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1040_Média_3
    {
        public static void Run()
        {
            int[] peso = new int[4] {
            2,
            3,
            4,
            1,
            };

            string[] vet = Console.ReadLine().Split(' ');

            double n1 = double.Parse(vet[0]);
            double n2 = double.Parse(vet[1]);
            double n3 = double.Parse(vet[2]);
            double n4 = double.Parse(vet[3]);

            double media = (n1 * peso[0] + n2 * peso[1] + n3 * peso[2] + n4 * peso[3]) / 10.0;

            media = Math.Truncate(10.0 * media) / 10.0;

            Console.WriteLine($"Media: {media.ToString("0.0")}");

            if (media >= 7.0)
                Console.WriteLine("Aluno aprovado.");
            else if (media >= 5.0 && media < 7.0)
            {
                Console.WriteLine("Aluno em exame.");
                double nExame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {nExame.ToString("0.0")}");

                media = (media + nExame) / 2.0;

                if (media > 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {media.ToString("0.0")}");
                }
                else
                    Console.WriteLine("Aluno reprovado.");
            }
            else if (media < 5.0)
                Console.WriteLine("Aluno reprovado.");
        }
    }
}
