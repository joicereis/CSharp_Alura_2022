using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes_Mat_Basicas.Operacoes
{
    internal class Operacoes
    {
        public Soma Soma { get; set; }
        public Subtracao Subtracao { get; set; }
        public Divisao Divisao { get; set; }
        public Multiplicacao Multiplicacao { get; set; }

        public Operacoes()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Divisao = new Divisao();
            this.Multiplicacao = new Multiplicacao();
        }
    }
}
