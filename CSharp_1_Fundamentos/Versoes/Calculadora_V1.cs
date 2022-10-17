using System;


namespace CSharp_1_Fundamentos.Versoes
{
    public static class Calculadora_V1
    {
        public static void Calcular()  //método
        {
            Console.WriteLine("CALCULADORA 1.0");
            Console.WriteLine("Vamos calcular!\n");
            Console.WriteLine("Informe o primeiro valor.\n");
            double vnVlrOperando1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor.\n");
            double vnVlrOperando2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o símbolo da operação.\n");
            char operacao = char.Parse(Console.ReadLine());

            //Operações
            double resultado = 0;

            switch (operacao)
            {
                case '+':
                    resultado = vnVlrOperando1 + vnVlrOperando2;
                    break;
                case '-':
                    resultado = vnVlrOperando1 - vnVlrOperando2;
                    break;
                case '*':
                    resultado = vnVlrOperando1 * vnVlrOperando2;
                    break;
                case '/':
                    /*usando o ternário - estabelece condição e joga resultado p variável ,
                    o que vem depois de ? é se o teste for verdadeiro e depois de : se o teste for false */
                    resultado = (vnVlrOperando2 != 0) ? vnVlrOperando1 / vnVlrOperando2 : 0;
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

            Console.WriteLine($"Resultado {resultado}");
        }
    }
}
