using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crie um programa que trabalhe um investimento com vencimento de 5 anos e que no primeiro ano o rendimento seja de 0,5,
no segundo ano seja de 0,6
no terceiro de 0,7
e assim sucessivamente.
*/
namespace InvestimentoALongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Investimento a Longo Prazo.\nO fator de rendimento aumenta de acordo com o tempo investido.\n");

            double fatorRendimento = 1.005; //significa que rende o valor investido mais 0,5% dele
            //no fator investimento poderia usar 0,5%
            double totalInvestido = 1000;

            for (int anos = 1; anos <= 5; anos++) 
            {
                for(int mes =1; mes < 13; mes++)
                {
                    totalInvestido = totalInvestido * fatorRendimento;
                    Console.WriteLine("Valor investido no mês "+ mes + " do ano " + anos + ": " + totalInvestido.ToString("C") + " ou " + totalInvestido);
                }
                Console.WriteLine("\n");
                fatorRendimento += 0.001;
            }
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}