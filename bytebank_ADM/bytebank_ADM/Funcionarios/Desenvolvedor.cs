using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {
        }
        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double getBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
