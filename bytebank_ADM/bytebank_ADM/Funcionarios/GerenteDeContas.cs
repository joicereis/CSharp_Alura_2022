using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public  class GerenteDeContas : Autenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }
        public override double getBonificacao()
        {
            return Salario *= 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
