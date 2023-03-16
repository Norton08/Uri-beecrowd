//https://www.beecrowd.com.br/repository/UOJ_1013.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1013_O_Maior
    {
        public static void Run()
        {
            int a, b, c;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);


            int maiorAbc = ((a + b + Math.Abs(a - b)) / 2);
            maiorAbc = ((maiorAbc + c + Math.Abs(maiorAbc - c)) / 2);

            Console.WriteLine(maiorAbc + " eh o maior");
        }
    }
}
