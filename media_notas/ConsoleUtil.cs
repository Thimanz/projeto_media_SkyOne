using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_notas
{
    internal class ConsoleUtil
    {
        public static ConsoleKey finalizar()
        {
            ConsoleKey continuar;
            do
            {
                Console.Write("Finalizar? [s/n] ");
                continuar = Console.ReadKey(false).Key;
                if (continuar != ConsoleKey.Enter)
                    Console.WriteLine();

            } while (continuar != ConsoleKey.S && continuar != ConsoleKey.N);
            return continuar;
        }
    }
}
