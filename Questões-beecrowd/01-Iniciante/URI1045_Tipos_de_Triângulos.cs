//https://www.beecrowd.com.br/repository/UOJ_1045.html
using System;
using System.Globalization;

namespace Questões_beecrowd.Iniciante  
{
    public class URI1045_Tipos_de_Triângulos
    {
        public static void Run()
        {
            double a, b, c, aux;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a < b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a < c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b < c)
            {
                aux = b;
                b = c;
                b = aux;
            }

            if (a <= 0 || b <= 0 || c <= 0 || a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a,2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (a == b && b == c && a == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
