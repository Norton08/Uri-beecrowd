//https://www.beecrowd.com.br/repository/UOJ_1061.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1061_Tempo_de_um_Evento
    {
        public static void Run()
        {
            string[] diaTal = Console.ReadLine().Split(' ');

            int dias = int.Parse(diaTal[1]);
            string[] vet = Console.ReadLine().Split(':');
            TimeSpan primeiroDia = new TimeSpan(dias, int.Parse(vet[0]), int.Parse(vet[1]), int.Parse(vet[2]));

            string[] diaTal2 = Console.ReadLine().Split(' ');
            dias = int.Parse(diaTal2[1]);
            string[] vet2 = Console.ReadLine().Split(':');
            TimeSpan ultimoDia = new TimeSpan(dias, int.Parse(vet2[0]), int.Parse(vet2[1]), int.Parse(vet2[2]));

            TimeSpan final = ultimoDia.Subtract(primeiroDia);

            Console.WriteLine($"{final.Days} dia(s)");
            Console.WriteLine($"{final.Hours} hora(s)");
            Console.WriteLine($"{final.Minutes} minuto(s)");
            Console.WriteLine($"{final.Seconds} segundo(s)");
        }
    }
}
