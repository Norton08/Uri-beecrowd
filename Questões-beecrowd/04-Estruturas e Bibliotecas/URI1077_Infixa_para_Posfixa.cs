//https://www.beecrowd.com.br/repository/UOJ_1077.html
using System;
using System.Collections.Generic;

namespace Questões_beecrowd.Estruturas_e_Bibliotecas
{
    public class URI1077_Infixa_para_Posfixa
    {
        static int GetPrioridade(char operatorr)
        {
            switch (operatorr)
            {
                case '^': return 4;

                case '*':
                case '/': return 3;

                case '+':
                case '-': return 2;

                case '(':
                case ')': return 1;

                default: return 0;
            }
        }
     
        static string InfixaParaPosfixa(string infixa)
        {

            var posfixa = "";
            var pilha = new Stack<char>();

            foreach (var caracter in infixa)
            {
                if (char.IsDigit(caracter) || char.IsLetter(caracter))
                {

                    posfixa += caracter;

                }
                else if (caracter == '(')
                {

                    pilha.Push(caracter);

                }
                else if (caracter == ')')
                {

                    while (pilha.Peek() != '(')
                    {

                        posfixa += pilha.Pop();

                    }

                    pilha.Pop();
                }
                //PUSH: INSERE O OBJETO NO TOPO DE UMA PILHA
                //POP: REMOVE E RETORNA O OBJETO NO TOPO DE UMA PILHA
                //PEEK: RETORNA O OBJETO DO TOPO SEM REMOVÊ-LO(PARA COMPARAÇÃO)
                else
                {
                    while (pilha.Count > 0 && GetPrioridade(pilha.Peek()) >= GetPrioridade(caracter))
                    {

                        posfixa += pilha.Pop();
                    }

                    pilha.Push(caracter);
                }
            }

            while (pilha.Count > 0)
            {

                posfixa += pilha.Pop();

            }

            return posfixa;
        }

        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string infixa = Console.ReadLine();
                Console.WriteLine(InfixaParaPosfixa(infixa));

            }
        }
    }
}




//A + B
//A B +

