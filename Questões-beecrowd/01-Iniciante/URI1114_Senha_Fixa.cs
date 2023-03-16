//https://www.beecrowd.com.br/repository/UOJ_1114.html
using System;
using System.Collections.Generic;
using System.Text;

namespace Questões_beecrowd.Iniciante
{
    public class URI1114_Senha_Fixa
    {
        public static void Run()
        {
            int senhaFixa = int.Parse(Console.ReadLine());

            while(senhaFixa != 2002)
            {
                if(senhaFixa != 2002)
                    Console.WriteLine("Senha Invalida");

                senhaFixa = int.Parse((Console.ReadLine()));
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
