//https://www.beecrowd.com.br/repository/UOJ_1049.html
using System;

namespace Questões_beecrowd.Iniciante
{
    public class URI1049_Animal
    {
        
        private static string[] Filo { get; set; } = { "vertebrado", "invertebrado" };
        private static string[] Classe { get; set; } = { "ave", "mamifero", "inseto", "anelideo" };
        private static string[] TipoAlimentacao { get; set; } = { "carnivoro", "onivoro", "herbivoro", "hematofago" };
        private static string[] TipoAnimal { get; set; } = { "aguia", "pomba", "homem", "vaca", "pulga", "lagarta", "sanguessuga", "minhoca" };
        private static string PegarAnimalPorCaracteristicas(ref string filo, ref string classe, ref string tipoalimentacao)
        {
            string tipoAnimal;

            if(filo == Filo[0])
            {
                if(classe == Classe[0])
                {
                    if (tipoalimentacao == TipoAlimentacao[0])
                    {
                        tipoAnimal = TipoAnimal[0];
                    }
                    else
                    {
                        tipoAnimal = TipoAnimal[1];

                    }
                }
                else
                {
                    if (tipoalimentacao == TipoAlimentacao[1])
                    {
                        tipoAnimal = TipoAnimal[2];
                    }
                    else
                    {
                        tipoAnimal = TipoAnimal[3];

                    }
                }
            }
            else
            {
                if (classe == Classe[2])
                {
                    if (tipoalimentacao == TipoAlimentacao[3])
                    {
                        tipoAnimal = TipoAnimal[4];
                    }
                    else
                    {
                        tipoAnimal = TipoAnimal[5];

                    }
                }
                else
                {
                    if (tipoalimentacao == TipoAlimentacao[3])
                    {
                        tipoAnimal = TipoAnimal[6];
                    }
                    else
                    {
                        tipoAnimal = TipoAnimal[7];

                    }
                }
            }
            return tipoAnimal;
        }
        public static void Run()
        {
            string filo = Console.ReadLine();
            string classe = Console.ReadLine();
            string tipoalimentacao = Console.ReadLine();

            string tipoAnimal = PegarAnimalPorCaracteristicas(ref filo, ref classe ,ref tipoalimentacao);

            Console.WriteLine(tipoAnimal);
        }
    }
}
