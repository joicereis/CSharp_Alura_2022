using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_Alura.Titular /* namespaces são estruturas de oorganização lógicas de classes utilizadas no .Net
                                   e podem organizar essas classes de forma hieráquicas
                                  * A organização de um projeto em namespaces permite a definição de hierarquias 
                                   para agrupar classes e namespaces que possuam características ou funcionalidades em comum.
                                  */
{
    public class Cliente
    {
        public string cpf;
        public string nome;
        public string profissao;

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }

    }
}
