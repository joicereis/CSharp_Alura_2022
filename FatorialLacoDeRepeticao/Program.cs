using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva um for que inicie uma variável n (número atual) como 1 e fatorial (resultado total) como 1.
 * Faça seu laço entre 1 a 10 e calcule o resultado!
 * IMPORTANTE:
    O fatorial de 1 é (0!) * 1 = 1
    O fatorial de 2 é (1!) * 2 = 2
  */
namespace FatorialLacoDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 0, fatorial = 1; // 0! =1   (Zero fatorial é igual à 1.)
            
            while (nro <= 10)
            {
                if (nro == 0)
                {
                    Console.WriteLine(nro + "! = " + fatorial);
                    nro++;
                }
                fatorial *= nro;
                Console.WriteLine(nro + "! = " + fatorial);
                nro++;
            }
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
