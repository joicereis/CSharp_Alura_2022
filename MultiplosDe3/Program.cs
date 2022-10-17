using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int nro = 1; nro <= 1000; nro++)
            {
                if (nro % 3 == 0)
                {
                    Console.WriteLine(nro);
                }
            }
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
