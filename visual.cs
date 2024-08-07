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

    public static void PuertaCerrada(int x, int y, ConsoleColor color)
    {
        Mostrar.WriteAt("███████████", x+2, y, color);
        Mostrar.WriteAt("██ ║ ║ ║ ║ ██", x+1, y+1,  color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y+2,  color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y+3,  color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y+4,  color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y+5,  color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y+6,  color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y+7,  color);
       
    }

    public static void PuertaAbierta(int x, int y, ConsoleColor color)
    {
        Mostrar.WriteAt("███████████", x+2, y, color);
        Mostrar.WriteAt("██ ║ ║ ║ ║ ██", x+1, y+1,  color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y+2,  color);
        Mostrar.WriteAt("██  ╚═╬═╬═╝  ██", x, y+3,  color);
        Mostrar.WriteAt("██           ██", x, y+4,  color);
        Mostrar.WriteAt("██           ██", x, y+5,  color);
        Mostrar.WriteAt("██           ██", x, y+6,  color);
        Mostrar.WriteAt("██           ██", x, y+7,  color);
       
    }

     public static void SeleccionPuerta(){
        Console.Clear();
        Mostrar.PuertaCerrada(10,4,ConsoleColor.DarkGreen);
        Mostrar.WriteAt("Puerta 1",13, 12, ConsoleColor.DarkGreen);
        Mostrar.PuertaCerrada(30,4,ConsoleColor.DarkBlue);
        Mostrar.WriteAt("Puerta 2",33, 12, ConsoleColor.DarkBlue);
        Mostrar.PuertaCerrada(50,4,ConsoleColor.DarkRed);
        Mostrar.WriteAt("Puerta 3",53, 12, ConsoleColor.DarkRed);

        
        Mostrar.WriteAt("Escoja una puerta: ",30, 14, ConsoleColor.Red);
        int i;
        int.TryParse(Console.ReadLine(), out i);
        switch (i)
            {
                case 1:
                     Mostrar.PuertaAbierta(10,4,ConsoleColor.DarkGreen);
                    break;
                case 2:
                     Mostrar.PuertaAbierta(30,4,ConsoleColor.DarkBlue);
                    break;
                case 3:
                    Mostrar.PuertaAbierta(50,4,ConsoleColor.DarkRed);
                    break;
            }

    }

}