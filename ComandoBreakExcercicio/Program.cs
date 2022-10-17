using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoBreakExcercicio
    /* Imprimir:
    1
    12
    123
    1234
    12345
    */
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (coluna >= linha)
                    {
                        break;
                    }
                    Console.Write(coluna + 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
