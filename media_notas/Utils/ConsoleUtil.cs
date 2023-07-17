namespace media_notas.Utils
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
