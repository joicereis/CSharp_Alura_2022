using byteBank_Alura.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_Alura
{
    public class ContaCorrente
    {  
        private Cliente titular;
        private string conta;
        private int nroAgencia;
        private string nomeAgencia;
      // public double saldo;
        private double saldo; // o  tipo private só permite que seja alterados os valores dos campos através de métodos da mesma classe

        //PROPRIEDADE PARA MANIPULAR TITULAR - Propriedade autoimplementada, usada quando não há validação dos campos
        public Cliente Titular
        {
            get;
            set;
        }

        private string _conta;
        public string Conta
        {
            get { return _conta; }
            set {
                if(value == null)
                    return;
                else
                    _conta = value; }
        }

        private int _numeroAgencia;
        public int NroAgencia
        {
            get { return _numeroAgencia; }
            set {
                if (value <= 0)
                    return;
                else
                   _numeroAgencia = value; }
        }
        public string NomeAgencia
        {
            get;
            set;
        }
        //PROPRIEDADES PARA MANIPULAR O SALDO - Pode ser usado ao invès dos métodos de GetSaldo e SetSaldo
        public double Saldo   //propriedades sempre se iniciam com letra maiúscula
        {
            get { return saldo; }
            set
            {
                if (value < 0)
                    return;
                else
                    saldo = value;
            }
        }

        //PROPRIEDADE PARA DEFINIR O NÚMERO DE CONTAS CRIADAS
        public static int TotalContasCriadas { get; set; }// o Static simboloiza que a propriedade não pertence à apenas uma instância do objeto mas sim de toda a classe

        //CONSTRUTOR - é um método que possui o mesmo nome da classe, ao ser instanciado um objeto é chamado um construtor de forma implícita pelo .Net
        public ContaCorrente(int numeroAgencia, string conta)
        {
            NroAgencia = numeroAgencia;
            conta = conta;
            TotalContasCriadas += 1; // toda vez que instanciar um objeto, será alimentado 1 à propriedade totalcontascriadas
        }

        //public ContaCorrente(Cliente titular,string nomeAgencia,int nroAgencia,string conta)
        //{
        //    Titular = titular;
        //    NomeAgencia = nomeAgencia;
        //    NroAgencia = nroAgencia;
        //    Conta=conta;
        //}


        //metodos
        public bool Sacar(double vlr)
        {  // nome de método é dado por verbo no infinitivo
            if(vlr < 0)
            {
                return false;
            }

            else if (saldo < vlr)
            {
                return false;
            }
            else
            {
                saldo -= vlr;
                return true;
            }
        }

        public void Depositar(double vlr)
        {
            if (vlr >= 0)
            {
                saldo += vlr;
            }
            else
            {
                Console.WriteLine("Nao é possível depositar valores negativos.");
            }
        }

        public bool Transferir(double valorTranf , ContaCorrente destino)
        {
            if (saldo < valorTranf)
                return false;

            else if (valorTranf <= 0)
                return false;
            else
            {
                saldo -= valorTranf;
                destino.saldo += valorTranf;
                return true;
            }
        }

        public void ExibirIformacoesConta()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Numero da Agencia: " + nroAgencia);
            Console.WriteLine("Nome da Agencia: " + nomeAgencia);
            Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", saldo)}");
        }
        
        /*
        //MÉTODO PUBLICO PARA DEFINIR O SALDO QUANDO ESSE TIVER VISIBILIDADE PRIVADA
        public void SetSaldo(double valor) 
        {
            if (valor < 0)
                return; //qnd o método é void, ao utulizar um return, o mesmo é interrompido
            else
                saldo += valor;
        }

        //MÉTODO PUBLICO PARA DEFINIR O SALDO QUANDO ESSE TIVER VISIBILIDADE PRIVADA
        public double GetSaldo()
        {
            return saldo;
        }
        */

    }
}
