using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1_PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)// FUNÇÃO PRINCIPAL DO PROGRAMA  que indica a inicialização do programa
        {
            Console.WriteLine("Olá, mundo! \nMeu primeiro Projeto no Visual Studio.");



            //Cast- conversão de tipos de dados

            double oito_bytes = 8.9;
            float quatro_bytes;

            quatro_bytes = (float)oito_bytes;

            Console.WriteLine(quatro_bytes);

            //casting de double para inteiro
            int var_int = (int)oito_bytes;
            Console.WriteLine(var_int);  //sempre arredonda para o menor numero inteiro

            int a = 5;
            int b = 2;

            // ao fazer uma divisão de dois dados de tipo inteiro, o sistema entende que desejaum resultado inteiro,
            // então precisa- se fazer o cast explícito

            double resultado = (double)a / b;
            Console.WriteLine(resultado);


            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            //Entrada de dados - TODA a entrada de dados através do comando ReadLine ocorre no formato de string
            //então para ler um valor e colocar em uma variável de tipo diferente de string, precisa usar a conversão ex int.Parse(Console.ReadLine())

            /*
            Console.WriteLine("Digite um valor inteiro.");
            int id = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o primeiro nome.");
            string nomeInteiro = Console.ReadLine();
            Console.WriteLine("Digite a altura separando metros de cm com o símbolo ','");
            double alt = double.Parse(Console.ReadLine());
            Console.WriteLine(alt);
            Console.WriteLine(nomeInteiro + "de altura " + alt);
            
            Console.WriteLine("Digite o sexo em 'F' ou 'M'.");
            char se = char.Parse(Console.ReadLine());
            */

            char valor = (char)(65 + 1);  //Impressão caracter pelo valor da tabela ASCII

            //VARIÁVEIS BOOLEANAS:
            int qtdPessoas = 10;
            bool grupoPessoas = qtdPessoas > 2; // testa se o valor da variável qtdPessoas é maior que 2, caso sim, retorna verdadeira.
            Console.WriteLine(grupoPessoas);
            /*

            //Entrada de dados em vetor
            string[] vet = Console.ReadLine().Split(' '); // o comando split informa que os dados dos vetor serão separado por ' '
            int ident = int.Parse(vet[0]);
            string nome = vet[1];
            char sexo = char.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine(ident);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura);

            */

            //FUNÇÕES:

            /*
            Console.WriteLine("Digite 3 números.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            
            int resultMaior = Maior(num1, num2, num3);// sendo resultMaior o nome da variável que recebe a saída da função chamada Maior
            Console.WriteLine("O maior número é " + resultMaior);

            Console.WriteLine("A execução acabou. Tecle 'Enter' para finalizar.");
            Console.ReadLine(); //essa função espera pela digitação de algo, está sendo utilizada para pausar a mtela após ser executada a impressão 

            pr int Maior(int nro1, int nro2, int nro3)
            {
                int m;

                if (nro1 > nro2 && nro1 > nro3)
                {
                    m = nro1;
                }
                else if (nro2 > nro3)
                {
                    m = nro2;
                }

                else
                {
                    m = nro3;
                }

                return m;
            } */

            //  Console.WriteLine("Digite enter para fechar");
            //  Console.ReadLine();

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }

    }
}