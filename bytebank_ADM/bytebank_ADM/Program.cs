using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;
using System.Security.AccessControl;

Console.WriteLine("Boas vindas ao byteBank Administração!");

// CalcularBonificacao();
UsarSistema();

void UsarSistema()
{
    SistemaInterno sistemaInterno= new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("326.985.628");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";

    Designer antonio = new Designer("326.985.628");
    ursula.Nome = "Antonio";

    ParceiroComercial felipe = new ParceiroComercial();
    felipe.Senha = "456";

    sistemaInterno.Logar(roberta, "222");
    sistemaInterno.Logar(ursula, "321");
    sistemaInterno.Logar(felipe, "456");
    // sistemaInterno.Logar(antonio, "321");
}

void CalcularBonificacao()
{
    GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();

    Designer pedro = new Designer("123");
    pedro.Nome = "Pedro";

    Diretor paula = new Diretor("456");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("789");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificações: " + gerenciador.getBonificacao());
}