//https://www.beecrowd.com.br/repository/UOJ_1071.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1071_Soma_de_Ímpares_Consecutivos_I
    {
        public static void Run()
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int soma = 0, i = 0;

            if(Y % 2 == 0) i = Y + 1;
            else i = Y + 2;
            
            for(; i < X && i >= Y ; i += 2) soma += i;
            
            Console.WriteLine(soma);
        }
    }
}
