using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario  // se tornou uma classe abstrata para que não seja obrigatório a implementação dos métodos de bonificação e de aumento de salários
    {
        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
