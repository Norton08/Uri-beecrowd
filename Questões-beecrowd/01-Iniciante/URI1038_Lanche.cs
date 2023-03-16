//https://www.beecrowd.com.br/repository/UOJ_1038.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1038_Lanche
    {
        public static void Run()
        {
            int cod, qtd;
            double[] preco = new double[5] {
            4.00,
            4.50,
            5.00,
            2.00,
            1.50
            };

            string[] vet = Console.ReadLine().Split(' ');

            cod = int.Parse(vet[0]);
            cod--;
            qtd = int.Parse(vet[1]);

            Console.WriteLine($"Total: R$ {preco[cod] * qtd:0.00}");
        }
    }
}
