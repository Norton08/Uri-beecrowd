//https://www.beecrowd.com.br/repository/UOJ_1035.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1035_Teste_de_Seleção_1
    {
        public static void Run()
        {
            int A, B, C, D;

            String[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
                Console.WriteLine("Valores nao aceitos");
        }
    }
}
