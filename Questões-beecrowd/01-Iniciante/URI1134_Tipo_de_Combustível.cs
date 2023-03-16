//https://www.beecrowd.com.br/repository/UOJ_1134.html
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1134_Tipo_de_Combustível
    {
        public static void Run()
        {
            int sair = 0, alcool = 0, gasolina = 0, diesel = 0;
            while (sair != 4)
            {
                sair = 0;
                sair = int.Parse(Console.ReadLine());
                if (sair == 1)
                    alcool += 1;
                else if (sair == 2)
                    gasolina += 1;
                else if (sair == 3)
                    diesel += 1;
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
