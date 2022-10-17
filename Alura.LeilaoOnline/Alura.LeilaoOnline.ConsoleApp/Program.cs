using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program

    {
        private static void Verifica(double esperado, double obtido)
        {
            var corConsole= Console.ForegroundColor; //capturando a cor do console
            if (esperado == obtido)
            {
                Console.ForegroundColor = ConsoleColor.Green; //alterando cor do console para verde
                Console.WriteLine("TESTE OK");
                Console.ForegroundColor = corConsole;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; //alterando cor do console para vermelho
                Console.WriteLine("TESTE FALHOU!");
                Console.ForegroundColor = corConsole;
                Console.WriteLine("O valor obtido foi " + obtido +".");
                Console.WriteLine("O valor esperado é " + esperado +".");
            }
        }

        public static void LeilaoComVariosLances()
        {
            //Arranje- Cenário- onde está sendo definido o cenário de entrada
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);


            //Act - método sob test- é onde executa o teste 
            leilao.TerminaPregao();

            //Assert- é onde ocorre a validação se o retorno é o esperado

            //Console.WriteLine(leilao.Ganhador.Valor);
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            Console.WriteLine("\nTeste com mais de um lance: ");
            Verifica(valorEsperado, valorObtido);
        }

        private static void LeilaComApenasUmLance()
        {
            //Arranje- Cenário- onde está sendo definido o cenário de entrada
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            

            leilao.RecebeLance(fulano, 700); 

            //Act - método sob test- é onde executa o teste 
            leilao.TerminaPregao();

            //Assert- é onde ocorre a validação se o retorno é o esperado

            //Console.WriteLine(leilao.Ganhador.Valor);
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;
            Console.WriteLine("\nTeste com apenas um lance: ");
            Verifica(valorEsperado, valorObtido);
        }

        static void Main(string[] args)
        {
            LeilaoComVariosLances();
            LeilaComApenasUmLance();
        }
    }
}

