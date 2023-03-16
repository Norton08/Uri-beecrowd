//https://www.beecrowd.com.br/repository/UOJ_1019.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1019_Conversão_de_Tempo
    {
        public static void Run()
        {
            int segundos = int.Parse(Console.ReadLine());
            int horas = 0, minutos = 0;

            if (segundos >= 3600)
            {
                horas = segundos;
                horas /= 3600;
                segundos -= 3600 * horas;
            }

            if (segundos >= 60 && segundos < 3600)
            {
                minutos = segundos;
                minutos /= 60;
                segundos -= 60 * minutos;
            }

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
