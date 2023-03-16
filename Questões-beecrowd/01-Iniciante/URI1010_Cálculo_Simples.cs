//https://www.beecrowd.com.br/repository/UOJ_1010.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1010_Cálculo_Simples
    {
        public static void Run()
        {
            int codigoPeca1, numPeca1, codigoPeca2, numPeca2;
            double valor1, valor2;

            string[] vetor = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vetor[0]);
            numPeca1 = int.Parse(vetor[1]);
            valor1 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            string[] vetor2 = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vetor2[0]);
            numPeca2 = int.Parse(vetor2[1]);
            valor2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);

            Console.WriteLine("VALOR A PAGAR: R$ " + (numPeca1 * valor1 + numPeca2 * valor2)
                   .ToString("0.00"), CultureInfo.InvariantCulture);
        }
    }
}
