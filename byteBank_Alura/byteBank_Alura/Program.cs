using byteBank_Alura;
using byteBank_Alura.Titular;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

Console.WriteLine("Boas vindas ao seu banco ByteBank!\n");

/*

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Andre Silva";
conta1.conta = "10123-x";
conta1.nroAgencia = 23;
conta1.nomeAgencia = "Agencia Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Silva"; ;
conta2.conta = "111999-x";
conta2.nroAgencia = 58;
conta2.nomeAgencia = "Agencia Central";
conta2.saldo = 101;

ContaCorrente conta3 = new ContaCorrente();

ContaCorrente conta4 = new ContaCorrente();
conta4.titular = "Amanda Silva"; ;
conta4.conta = "111999-x";
conta4.nroAgencia = 58;
conta4.nomeAgencia = "Agencia Central";
conta4.saldo = 101;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Numero da Agencia: " + conta1.nroAgencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nomeAgencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

// imprimindo objeto vazio, sem atribuição de dados - com isso o valor padrão de string é vazio, os númericos tem o valor 0 e a booleanas tem valor false.
Console.WriteLine("Titular: " + conta3.titular);
Console.WriteLine("Conta: " + conta3.conta);
Console.WriteLine("Numero da Agencia: " + conta3.nroAgencia);
Console.WriteLine("Nome da Agencia: " + conta3.nomeAgencia);
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta3.saldo)}");

double saldo = 100;
double saldo2 = 100;
Console.WriteLine(saldo == saldo2); //vai verificar se é verdadeiro ou falso a coparação e imprimir em false ou true
Console.WriteLine(saldo2 == conta2.saldo);

saldo2 = conta2.saldo;
Console.WriteLine(saldo2 == conta2.saldo);//vai verificar se é verdadeiro ou falso a coparação e imprimir em false ou true


// TIPAGEM DE VALOR POR REFERENCIA - Endereço de memória  - Se alterar o valor do conta4, altera-se tbm o valor do conta 2 e vice versa
//Compara se os tipos de dados 
Console.WriteLine("\nTipagem por Referencia");
Console.WriteLine(conta2 == conta4); //vai dar falso pois os endereços de memória são diferentes

Console.WriteLine("\nTipagem por Referencia 2: ");
conta4 = conta2; // objetos apontando para o mesmo endereço
Console.WriteLine(conta2 == conta4); //vai dar verdadeiro pois os o conta4 aponta para o endereço de memória do conta2

conta4.saldo = 500; // vai alterar tbm o valor do conta2, pois o conta4 aponta para o mesmo endereço de memória
Console.WriteLine("\nSaldo conta2 " + conta2.saldo + " e saldo conta4: " + conta4.saldo);


Console.WriteLine("\nROUPAS:");
Roupa roupa1 = new Roupa();
roupa1.fabricante ="Moda Jeans";
roupa1.valor = 63.0;

Roupa roupa2 = roupa1;
roupa2.valor = roupa2.valor + 1000;
Console.WriteLine("Roupa1: " + roupa1.valor);
Console.WriteLine("Roupa2: " + roupa2.valor);


//CHAMANDO MÉTODOS
Console.WriteLine("\nSAQUE:");
Console.WriteLine("Saldo pré-saque: " + conta2.saldo);
conta2.Sacar(-50);
Console.WriteLine("Saldo pós-saque: " + conta2.saldo);

Console.WriteLine("\nDEPÓSITO:");
conta2.Depositar(60);
Console.WriteLine("Saldo após depósito: " + conta2.saldo);

Console.WriteLine( "\nTRANSFERÊNCIA:");
Console.WriteLine("Saldo pré- transferência da conta1: " + conta1.saldo + " e saldo conta2: " + conta2.saldo);
bool transferencia= conta1.Transferir(0, conta2);
Console.WriteLine("Saldo pós- transferência da conta1: " + conta1.saldo + " e saldo conta2: " + conta2.saldo);
Console.WriteLine(transferencia);

Console.WriteLine("\nEXIBIR INFOS DA CONTA");
conta1.ExibirIformacoesConta();
*/

//Cliente cliente1 = new Cliente();
//cliente1.nome = "Joice";
//cliente1.cpf = "1010101010";
//cliente1.profissao = "Programadora C#";

// Console.WriteLine(cliente1.nome);

/* ALTERADO O CAMPO TITULAR PARA PRIVATE
ContaCorrente conta5 = new ContaCorrente();
conta5.titular = new Cliente(); //instanciando um objeto e já associando ao objeto conta5
conta5.titular.cpf = "1010101010";
conta5.titular.profissao = "Programadora C#"; 
conta5.conta = "55544-x";
conta5.nroAgencia = 71;
conta5.nomeAgencia = "Agencia Correios";
// conta5.saldo = 150.00;  -- alterei  o atributo para private

if(conta5.titular == null)
{
    Console.WriteLine("O campo titular está nulo."); // quando não for instanciado um objeto de tipo Cliente
}
else
    Console.WriteLine(conta5.titular.nome);


*/


Cliente sarah = new Cliente();

Console.WriteLine("\nVISIBILIDADE DE CAMPOS.");
ContaCorrente conta6 = new ContaCorrente(235, "123456-x");

/* Quando não há a proteção de visibilidade do atributo da conta, qualquer pessoa de qlqr parte do código pode alterar seu valor
conta6.saldo = -10; //quando não há a proteção de visibilidade do atributo da conta, qualquer pessoa de qlqr parte do código pode alterar seu valor
Console.WriteLine("Saldo conta6:" + conta6.saldo);
*/

/*
//DEFININDO SALDO ATRAVÉS DE MÉTODO:
conta6.SetSaldo(-10);
Console.WriteLine("Saldo conta6:" + conta6.GetSaldo); // não consigo acessar o saldo diretamente, então criei um método para acessá-lo
conta6.SetSaldo(5);
Console.WriteLine("Saldo conta6:" + conta6.GetSaldo);
*/

conta6.Saldo = 150;
Console.WriteLine("Saldo da conta 6: " + conta6.Saldo);
conta6.Saldo= -10;
Console.WriteLine("Saldo da conta 6: " + conta6.Saldo);

conta6.Titular = sarah;
Console.WriteLine("\nMétodo construtor.");
Console.WriteLine(conta6.NroAgencia);
Console.WriteLine(conta6.Conta);

//CRIANDO NOVAS CONTAS
ContaCorrente conta7 = new ContaCorrente(276, "123458-x");
ContaCorrente conta8 = new ContaCorrente(261, "123458-x");

Console.WriteLine("\nTotal de Contas Criadas: " + ContaCorrente.TotalContasCriadas); /* chamei a classe e não o objeto pq a propriedade TotalContasCriadas é estática,
                                                                                      * ou seja, parte de toda a classe e não de um objeto */

Console.ReadKey();