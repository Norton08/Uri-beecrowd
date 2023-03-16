//https://www.beecrowd.com.br/repository/UOJ_1050.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1050_DDD
    {
        private static int[] DDD { get; set; } = { 61, 71, 11, 21, 32, 19, 27, 31 };
        private static string[] Cidade { get; set; } = { "Brasilia", "Salvador", "Sao Paulo", "Rio de Janeiro", "Juiz de Fora", "Campinas", "Vitoria", "Belo Horizonte" };
        private static int Codigo { get; set; } = 0;
        public static void Run()
        {
            int ddd = int.Parse(Console.ReadLine());

            foreach(int i in DDD)
            {
                if(i == ddd)
                {
                    Console.WriteLine(Cidade[Codigo]);
                    break;
                }
                Codigo++;
            }

            if(Codigo > 7)
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}
