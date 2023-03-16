//https://www.beecrowd.com.br/repository/UOJ_1043.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante
{
    public class URI1043_Triângulo
    {
        public static void Run()
        {
            string[] vet = Console.ReadLine().Split(' ');
            string[] str = new string[2] { "Area =", "Perimetro =" };

            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            bool cond1 = A + B > C;
            bool cond2 = A + C > B;
            bool cond3 = B + C > A;

            if (!(cond1 && cond2 && cond3))
            {
                double area = (A+B)*C/2.0;
                Console.WriteLine($"{str[0]} {area:0.0}");
            }
            else
            {
                double perimetro = A + B + C;   
                Console.WriteLine($"{str[1]} {perimetro:0.0}");
            }
        }
    }
}
