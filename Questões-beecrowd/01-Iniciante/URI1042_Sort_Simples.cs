//https://www.beecrowd.com.br/repository/UOJ_1042.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1042_Sort_Simples
    {
        public static void Run()
        {
            int temp;
            string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int z = int.Parse(vet[2]);

            int A = x;
            int B = y;
            int C = z;

            if (A > B)
            {
                temp = A;
                A = B;
                B = temp;
            }
            if (A > C)
            {
                temp = A;
                A = C;
                C = temp;
            }
            if (B > C)
            {
                temp = B;
                B = C;
                C = temp;
            }

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
