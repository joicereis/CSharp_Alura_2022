using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario  //definição de classe que servirá como base para criar outras classes derivadas - classe abstrata
    //ao definir uma classe como abstrata, não é mais possível criar instâncias de objetos para ela, só é possível apenas para suas derivadas que são concretas
    {

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; } // protected permite serem alteradas os valores das propriedades apenas pelos métodos da classe ou de suas derivadas 
        public static int TotalFuncionarios { get; private set; } // a palavra static define que a propriedade é da classe e não do objeto
                                                                  // o set como privado não permite que a propriedade seja alterada de qlqr lugar
        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        // a palavra reservada virtual simboliza que classses que herdam dessa, podem ter seus métodos reescritos
        // a palavra abstract representa que é só um modelo de objeto ou método mas que não pode ser estancioada
        public abstract double getBonificacao(); //métodos abstratos só existem em classes abstratas

        public abstract void AumentarSalario();



    }
}
