
using CSharp_1_Fundamentos.Versoes;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharp_1_Fundamentos
{
    class Program
    {
        static void Main()
        {
            // Calculadora_V1.Calcular();

            //Cenário 1 - Uso completo de todos os cenários
            Calculadora_V2 calculadora1_v2 = new Calculadora_V2();
                    
            calculadora1_v2.ExibirCabecalho();
            calculadora1_v2.EntradaDeDados();
            calculadora1_v2.ExibirResultado();
          
            Console.ReadLine();
        }
    }
}
