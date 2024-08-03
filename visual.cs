namespace Visuales
{
    public static class Mostrar
    {
        public static void WriteAt(string s, int x, int y, ConsoleColor z)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = z;

                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
    }
}