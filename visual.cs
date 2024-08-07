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


    public static void Logo()
    {
        Mostrar.WriteAt("█████  █   █  █████     ████   ██  ██  █   █  █████  █████  █████  █   █", 10, 2, ConsoleColor.White);
        Mostrar.WriteAt("█    █   █  █         █   █  ██  ██  ██  █  █      █      █   █  ██  █", 12, 3, ConsoleColor.White);
        Mostrar.WriteAt("█    █████  ████      █   █  ██  ██  █████  █ ███  ████   █   █  █████", 12, 4, ConsoleColor.White);
        Mostrar.WriteAt("█    █   █  █         █   █  ██  ██  █  ██  █  ██  █      █   █  █  ██", 12, 5, ConsoleColor.White);
        Mostrar.WriteAt("█    █   █  █████     ████    ████   █   █  █████  █████  █████  █   █", 12, 6, ConsoleColor.White);

    }
}