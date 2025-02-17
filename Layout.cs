namespace Layout
{
    class Formatacao
    {
        public static void AplicarCor(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}