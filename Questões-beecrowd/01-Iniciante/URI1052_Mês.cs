//https://www.beecrowd.com.br/repository/UOJ_1052.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1052_Mês
    {
        private static string[] Meses { get; set; } = { "January",
                                                        "February",
                                                        "March",
                                                        "April", 
                                                        "May",
                                                        "June",
                                                        "July",
                                                        "August",
                                                        "September",
                                                        "October",
                                                        "November",
                                                        "December", };
        public static void Run()
        {
            int numMes = int.Parse(Console.ReadLine());
            numMes--;
            string mes = Meses[numMes];

            Console.WriteLine(mes);
        }
    }
}
