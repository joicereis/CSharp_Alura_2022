using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Realizar a impressão dos asteriscos conforme abaixo usando o comando usando Break:
    //*
    //**
    //***
    //****
    //****

Linha 1:  1 asterico;
linha 2: 2 asteriscos;
...
Linha 9: 9 asteriscos
 */
namespace ComandoBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*"); // Não pode usar o WriteLine pois o mesmo quebra linhas
                    if (coluna >= linha) //se a coluna for >= numero da linha, deve parar a execução do for e pular para o bloco de fora que nesse caso é outro for
                        break;
                }
                Console.WriteLine(); //o Console.WriteLine já pula linhas, então não precisa pedir para pular mais
            }
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
