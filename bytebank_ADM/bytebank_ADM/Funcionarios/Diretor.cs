using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Autenticavel
    {   
        public Diretor(string cpf) : base(cpf, 5000)//invocando o constrtutor da classe base
        {
        }
        // a palavra reservada override simboliza que classses filha(herdeira), podem reescrever os métodos da classe base - polimorfismo
        public override double getBonificacao()
        {
            //return Salario + base.getBonificacao(); // está pégando o salário do diretor e através da palabra base somando com o que é retornado no método getBonificacao
            // da classe base que é funcionário (que calcula os 10%) 
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15; //está somando 0% ao salário
        }

       
    }
}
