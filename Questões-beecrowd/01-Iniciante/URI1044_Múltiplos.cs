//https://www.beecrowd.com.br/repository/UOJ_1044.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1044_Múltiplos
    {
        public static void Run()
        {
            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if(a % b == 0 || b % a == 0) 
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
