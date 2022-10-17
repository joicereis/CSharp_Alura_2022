using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1_Fundamentos.Versoes
{
    public class Calculadora_V2
    {
        //propriedades
        public double VlrOperando1 { get; set; }

        public double VlrOperando2 { get; set; }

        public string Operador { get; set; }

        //construtores
        public Calculadora_V2() : this(0, 0, "") { }
        
        public Calculadora_V2 (double pOperando1, double pOperando2, string pOperador)
        {
            VlrOperando1 = pOperando1;
            VlrOperando2 = pOperando2;
            Operador = pOperador;
        }

        //métodos
        public void ExibirCabecalho()
        {   
            Console.WriteLine( MontarCabecalho() );
        }
        
        private string MontarCabecalho()
        {
            StringBuilder textoCabecalho = new StringBuilder();
            textoCabecalho.AppendLine("CALCULADORA 2.0");
            textoCabecalho.AppendLine("Vamos calcular!\n");

            return textoCabecalho.ToString();
        }

        public void EntradaDeDados()
        {
            VlrOperando1 = ObterVlrOperando("Informe o primeiro valor: ");
            VlrOperando2 = ObterVlrOperando("Informe o segundo valor: ");
            Operador = ObterOperador("Informe a operação: ");
        }

        private double ObterVlrOperando(string pMensagem)
        {
            Console.Write(pMensagem);
            return double.Parse(Console.ReadLine());
        }

        private string ObterOperador(string pMensagem)
        {
            Console.Write(pMensagem);
            return Console.ReadLine();
        }

        public void ExibirResultado()
        {
            Console.WriteLine($"O resultado é: {Calcular()}");
        }

        private double Calcular()
        {
            switch (Operador)
            {
                case "+":
                    return VlrOperando1 + VlrOperando2;

                case "-":
                    return VlrOperando1 - VlrOperando2;
                    
                case "*":
                    return VlrOperando1 * VlrOperando2;
                    
                case "/":
                    return (VlrOperando2 != 0) ? VlrOperando1 / VlrOperando2 : 0;
                    
                default:
                    Console.WriteLine("Operação inválida!");
                    return 0.0d;
            }
        }
    }
}
