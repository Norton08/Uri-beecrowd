//https://www.beecrowd.com.br/repository/UOJ_1048.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1048_Aumento_de_Salário
    {
        private static int Codigo { get; set; }
        private static double PegarCalculoSalario(ref double salario, ref double porcentagem)
        {
            if(salario > 2000.00) {
                porcentagem = 4;
                Codigo += 4;
            }
            else if (salario <= 2000.00 && salario > 1200.00)
            {
                porcentagem = 7;
                Codigo += 3;
            }
            else if (salario <= 1200.00 && salario > 800.00)
            {
                porcentagem = 10;
                Codigo += 2;
            }
            else if (salario <= 800.00 && salario > 400.00)
            {
                porcentagem = 12;
                Codigo += 1;
            }
            else if (salario <= 400.00)
            {
                porcentagem = 15;
                Codigo = 0;
            }

            return salario * (porcentagem / 100 + 1);
        }
        public static void Run()
        {
            string[] percentualReajuste = { "15", "12", "10", "7", "4" };

            double porcentagem = 0;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double recalculoSalario = PegarCalculoSalario(ref salario, ref porcentagem);

            Console.WriteLine($"Novo salario: {recalculoSalario:0.00}");
            Console.WriteLine($"Reajuste ganho: {recalculoSalario - salario:0.00}");
            Console.WriteLine($"Em percentual: {percentualReajuste[Codigo]} %");
        }
    }
}
