//https://www.beecrowd.com.br/repository/UOJ_1028.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Matemática
{
    public class URI1028_Figurinhas
    {
        public static int Mdc(int F1, int F2)
        {
            if (F2 == 0)
                return F1;

            return Mdc(F2, F1 % F2);
        }

        public static void Run()
        {
            int casosTeste = int.Parse(Console.ReadLine());

            for(int i = 0; i < casosTeste; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int f1 = Convert.ToInt32(vet[0]);
                int f2 = Convert.ToInt32(vet[1]);

                int mdc = Mdc(f1, f2);

                Console.WriteLine(mdc);
            }
        }
    }
}
