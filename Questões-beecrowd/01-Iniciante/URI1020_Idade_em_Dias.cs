//https://www.beecrowd.com.br/repository/UOJ_1020.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1020_Idade_em_Dias
    {
        public static void Run()
        {
            int dias = int.Parse(Console.ReadLine());
            int anos = 0, meses = 0;

            if (dias >= 365)
            {
                anos = dias;
                anos /= 365;
                dias -= 365 * anos;
            }

            if (dias >= 30 && dias < 365)
            {
                meses = dias;
                meses /= 30;
                dias -= 30 * meses;
            }

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}
