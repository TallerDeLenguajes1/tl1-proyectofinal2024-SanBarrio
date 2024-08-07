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
        Mostrar.WriteAt("███████████", x + 2, y, color);
        Mostrar.WriteAt("██ ║ ║ ║ ║ ██", x + 1, y + 1, color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y + 2, color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y + 3, color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y + 4, color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y + 5, color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y + 6, color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y + 7, color);

    }

    public static void PuertaAbierta(int x, int y, ConsoleColor color)
    {
        Mostrar.WriteAt("███████████", x + 2, y, color);
        Mostrar.WriteAt("██ ║ ║ ║ ║ ██", x + 1, y + 1, color);
        Mostrar.WriteAt("██══╬═╬═╬═╬══██", x, y + 2, color);
        Mostrar.WriteAt("██  ╚═╬═╬═╝  ██", x, y + 3, color);
        Mostrar.WriteAt("██           ██", x, y + 4, color);
        Mostrar.WriteAt("██           ██", x, y + 5, color);
        Mostrar.WriteAt("██           ██", x, y + 6, color);
        Mostrar.WriteAt("██           ██", x, y + 7, color);

    }

    public static void SeleccionPuerta()
    {
        Console.Clear();
        Mostrar.PuertaCerrada(10, 4, ConsoleColor.DarkGreen);
        Mostrar.WriteAt("Puerta 1", 13, 12, ConsoleColor.DarkGreen);
        Mostrar.PuertaCerrada(30, 4, ConsoleColor.DarkBlue);
        Mostrar.WriteAt("Puerta 2", 33, 12, ConsoleColor.DarkBlue);
        Mostrar.PuertaCerrada(50, 4, ConsoleColor.DarkRed);
        Mostrar.WriteAt("Puerta 3", 53, 12, ConsoleColor.DarkRed);


        Mostrar.WriteAt("Escoja una puerta: ", 30, 14, ConsoleColor.Red);
        int i;
        int.TryParse(Console.ReadLine(), out i);
        switch (i)
        {
            case 1:
                Mostrar.PuertaAbierta(10, 4, ConsoleColor.DarkGreen);
                break;
            case 2:
                Mostrar.PuertaAbierta(30, 4, ConsoleColor.DarkBlue);
                break;
            case 3:
                Mostrar.PuertaAbierta(50, 4, ConsoleColor.DarkRed);
                break;
        }

    }

    public static void Perdedor()
    {
        Console.Clear();
        Mostrar.WriteAt("█      █████  █████  █████ █████", 20, 12, ConsoleColor.Red);
        Mostrar.WriteAt("█      █   █  █      █     █   █", 20, 13, ConsoleColor.Red);
        Mostrar.WriteAt("█      █   █  █████  ████  ████  ", 20, 14, ConsoleColor.Red);
        Mostrar.WriteAt("█      █   █      █  █     █   █", 20, 15, ConsoleColor.Red);
        Mostrar.WriteAt("█████  █████  █████  █████ █   █", 20, 16, ConsoleColor.Red);
    }

    public static void Ganador()
    {
        Console.Clear();
        Mostrar.WriteAt("█████  █████  █   █  █████  █████  █████  █████", 20, 12, ConsoleColor.Green);
        Mostrar.WriteAt("█      █   █  ██  █  █   █  █        █    █", 20, 13, ConsoleColor.Green);
        Mostrar.WriteAt("█ ███  █████  █████  █████  █████    █    ████", 20, 14, ConsoleColor.Green);
        Mostrar.WriteAt("█   █  █   █  █  ██  █   █      █    █    █", 20, 15, ConsoleColor.Green);
        Mostrar.WriteAt("█████  █   █  █   █  █   █  █████    █    █████", 20, 16, ConsoleColor.Green);
    }


    public static void PersonajeBase(string clase, int x, int y)
    {
        if (clase == "Mago")
        {
            WriteAt("O  *", x, y, ConsoleColor.White);
            WriteAt("/|\\/", x - 1, y + 1, ConsoleColor.White);
            WriteAt("/ \\", x - 1, y + 2, ConsoleColor.White);
        }
        else if (clase == "Caballero")
        {
            WriteAt("|", x, y, ConsoleColor.White);
            WriteAt("║ O/─\\", x, y + 1, ConsoleColor.White);
            WriteAt("┼/|)o(", x, y + 2, ConsoleColor.White);
            WriteAt("/ \\─/", x + 1, y + 3, ConsoleColor.White);
        }
        else
        {
            WriteAt("O  ┐", x, y, ConsoleColor.White);
            WriteAt("╠\\'=╬≡", x-1, y+1, ConsoleColor.White);
            WriteAt("/ \\ ┘", x-1, y+2, ConsoleColor.White);
        }
    }
    public static void EnemigoBase(string monstruo, int x, int y)
    {
        if (monstruo == "Giant Spider")
        {
            WriteAt("__", x, y, ConsoleColor.Blue);
            WriteAt("(  )", x - 1, y + 1, ConsoleColor.Blue);
            WriteAt("/`  |´\\\\", x - 4, y + 2, ConsoleColor.Blue);
            WriteAt("°°", x - 2, y + 2, ConsoleColor.Magenta);
            WriteAt("´    '  ``", x - 5, y + 3, ConsoleColor.Blue);
        }
        else
        {
            WriteAt("|/)", 33, 10, ConsoleColor.DarkGreen);
            WriteAt("o.─._", 32, 11, ConsoleColor.DarkGreen);
            WriteAt("´ /|`─`", 31, 12, ConsoleColor.DarkGreen);
            WriteAt("`'", 33, 12, ConsoleColor.DarkGreen);
        }
    }
    public static async void AtaquePersonaje(string clase, int x, int y)
    {
        if (clase == "Mago")
        {

            for (int i = 1; i <= 12; i++)
            {
                WriteAt("                    ", x - 7, y - 1, ConsoleColor.White);
                WriteAt("                    ", x - 7, y, ConsoleColor.White);
                WriteAt("                    ", x - 7, y + 1, ConsoleColor.White);
                WriteAt("                    ", x - 7, y + 2, ConsoleColor.White);
                WriteAt("                    ", x - 7, y + 3, ConsoleColor.White);
                switch (i)
                {
                    case 1:
                        WriteAt("*", x, y, ConsoleColor.White);
                        WriteAt("O |", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|¯¯", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 2:
                        WriteAt("*", x - 2, y - 1, ConsoleColor.White);
                        WriteAt("\\", x - 1, y, ConsoleColor.White);
                        WriteAt("O/", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 3:
                        WriteAt("*──", x - 5, y, ConsoleColor.White);
                        WriteAt("O)", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 4:
                        WriteAt("'", x - 4, y - 1, ConsoleColor.White);
                        WriteAt("─ *──", x - 7, y, ConsoleColor.White);
                        WriteAt(". O)", x - 4, y + 1, ConsoleColor.White);
                        WriteAt("/|", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 5:
                        WriteAt(".", x - 4, y - 1, ConsoleColor.White);
                        WriteAt("-*──", x - 6, y, ConsoleColor.White);
                        WriteAt("' O)", x - 4, y + 1, ConsoleColor.White);
                        WriteAt("/|", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 6:
                        WriteAt("*", x - 2, y - 1, ConsoleColor.White);
                        WriteAt("\\", x - 1, y, ConsoleColor.White);
                        WriteAt("O/", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 7:
                        WriteAt("*", x, y, ConsoleColor.White);
                        WriteAt("O_/", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 8:
                        WriteAt("O", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|\\──*", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 9:
                        WriteAt("O", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|\\──*", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("◄■", x + 5, y + 2, ConsoleColor.Red);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 10:
                        WriteAt("O", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|\\──*", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("██", x + 8, y + 2, ConsoleColor.Red);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    case 11:
                        WriteAt("O", x - 2, y + 1, ConsoleColor.White);
                        WriteAt("/|\\──*", x - 3, y + 2, ConsoleColor.White);
                        WriteAt("██", x + 11, y + 2, ConsoleColor.Red);
                        WriteAt("/ \\", x - 3, y + 3, ConsoleColor.White);
                        break;
                    default:
                        PersonajeBase(clase, x - 2, y + 1);
                        break;
                }
                await Task.Delay(40);

            }
        }
        else if (clase == "Arquero")
        {
            for (int i = 1; i <= 7; i++)
            {
                WriteAt("                         ", x - 3, y, ConsoleColor.White);
                WriteAt("                         ", x - 3, y + 1, ConsoleColor.White);
                WriteAt("                         ", x - 3, y + 2, ConsoleColor.White);
                switch (i)
                {
                    case 1:
                        WriteAt("O  ┐", x, y, ConsoleColor.White);
                        WriteAt("╠\\'=╬≡", x-1, y+1, ConsoleColor.White);
                        WriteAt("/ \\ ┘", x-1, y+2, ConsoleColor.White);
                        break;
                    case 2:
                        WriteAt("O  ┐ ´", x, y, ConsoleColor.White);
                        WriteAt("╠\\'=╬≡~", x-1, y+1, ConsoleColor.White);
                        WriteAt("©", x+6, y+1, ConsoleColor.Green);
                        WriteAt("/ \\ ┘ ,", x-1, y+2, ConsoleColor.White);
                        break;
                    case 3:
                        WriteAt("O ┐   ·", x, y, ConsoleColor.White);
                        WriteAt("╠(='╬≡« ·", x-2, y+1, ConsoleColor.White);
                        WriteAt("©", x+8, y+1, ConsoleColor.Green);
                        WriteAt("/ \\┘   ·", x-1, y+2, ConsoleColor.White);
                        break;
                    case 4:
                        WriteAt("O ┐     ´", x, y, ConsoleColor.White);
                        WriteAt("╠(='╬≡ ·", x-2, y+1, ConsoleColor.White);
                        WriteAt("©", x+10, y+1, ConsoleColor.Green);
                        WriteAt("/ \\┘    ·", x-1, y+2, ConsoleColor.White);
                        break;
                    case 5:
                        WriteAt("O ┐      '", x, y, ConsoleColor.White);
                        WriteAt("╠(='╬≡", x-2, y+1, ConsoleColor.White);
                        WriteAt("<©>", x+12, y+1, ConsoleColor.Green);
                        WriteAt("/ \\┘     ·", x-1, y+2, ConsoleColor.White);
                        break;
                    case 6:
                        WriteAt("O ┐", x, y, ConsoleColor.White);
                        WriteAt("\\ ' /", x+12, y, ConsoleColor.Red);
                        WriteAt("╠(='╬≡", x-2, y+1, ConsoleColor.White);
                        WriteAt("- × -", x+12, y+1, ConsoleColor.Red);
                        WriteAt("/ \\┘", x-1, y+2, ConsoleColor.White);
                        WriteAt("/ · \\ ", x+12, y+2, ConsoleColor.Red);
                        break;

                    default:
                        PersonajeBase(clase, x, y);
                        break;
                }
                await Task.Delay(60);
            }
        }
        else
        {
            for (int i = 1; i <= 10; i++)
            {
                WriteAt("                    ", x - 4, y - 1, ConsoleColor.White);
                WriteAt("                    ", x - 4, y, ConsoleColor.White);
                WriteAt("                    ", x - 4, y + 1, ConsoleColor.White);
                WriteAt("                    ", x - 4, y + 2, ConsoleColor.White);
                WriteAt("                    ", x - 4, y + 3, ConsoleColor.White);
                switch (i)
                {
                    case 1:
                        WriteAt("|", x, y, ConsoleColor.White);
                        WriteAt("║ O /\\", x, y + 1, ConsoleColor.White);
                        WriteAt("┼/|`)o", x, y + 2, ConsoleColor.White);
                        WriteAt("/ \\\\/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    case 2:
                        WriteAt("|", x, y - 1, ConsoleColor.White);
                        WriteAt("║", x, y, ConsoleColor.White);
                        WriteAt("┼_O /\\", x, y + 1, ConsoleColor.White);
                        WriteAt("|¯)(", x + 2, y + 2, ConsoleColor.White);
                        WriteAt("/ \\\\/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    case 3:
                        WriteAt("──═┼", x - 3, y, ConsoleColor.White);
                        WriteAt("\\O/─\\", x + 1, y + 1, ConsoleColor.White);
                        WriteAt("|¯ (", x + 2, y + 2, ConsoleColor.White);
                        WriteAt("/ \\─/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    case 4:
                        WriteAt("──═┼", x - 3, y, ConsoleColor.White);
                        WriteAt("\\O─\\", x + 1, y + 1, ConsoleColor.White);
                        WriteAt("|V(", x + 2, y + 2, ConsoleColor.White);
                        WriteAt("/\\\\/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    case 5:
                        WriteAt(".---._", x - 2, y - 1, ConsoleColor.Blue);
                        WriteAt("'       '.", x - 3, y, ConsoleColor.Blue);
                        WriteAt("O─\\", x + 2, y + 1, ConsoleColor.White);
                        WriteAt("\\\\", x + 5, y + 1, ConsoleColor.Blue);
                        WriteAt("\\┼═──", x + 2, y + 2, ConsoleColor.White);
                        WriteAt("/\\\\/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    case 6:
                        WriteAt("O─\\", x + 2, y + 1, ConsoleColor.White);
                        WriteAt("\\┼═──", x + 2, y + 2, ConsoleColor.White);
                        WriteAt("/\\\\/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    case 7:
                        WriteAt("O/─\\", x + 2, y + 1, ConsoleColor.White);
                        WriteAt("/┼═──", x + 1, y + 2, ConsoleColor.White);
                        WriteAt("/ \\─/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    case 8:
                        WriteAt("|", x, y, ConsoleColor.White);
                        WriteAt("║ O /\\", x, y + 1, ConsoleColor.White);
                        WriteAt("┼/|¯)(", x, y + 2, ConsoleColor.White);
                        WriteAt("/ \\\\/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    case 9:
                        WriteAt("|", x, y, ConsoleColor.White);
                        WriteAt("║ O /\\", x, y + 1, ConsoleColor.White);
                        WriteAt("┼/|`)o", x, y + 2, ConsoleColor.White);
                        WriteAt("/ \\\\/", x + 1, y + 3, ConsoleColor.White);
                        break;
                    default:
                        PersonajeBase(clase, x, y);
                        break;
                }
                await Task.Delay(60);
            }
        }
    }


    public static async void AtaqueEnemigo(string monstruo, int x, int y)
    {

        if (monstruo == "Giant Spider")
        {

            for (int i = 1; i <= 8; i++)
            {
                WriteAt("                    ", x - 7, y - 1, ConsoleColor.White);
                WriteAt("                    ", x - 7, y, ConsoleColor.White);
                WriteAt("                    ", x - 7, y + 1, ConsoleColor.White);
                WriteAt("                    ", x - 7, y + 2, ConsoleColor.White);
                WriteAt("                    ", x - 7, y + 3, ConsoleColor.White);
                WriteAt("                    ", x - 7, y + 4, ConsoleColor.White);
                switch (i)
                {
                    case 1:
                        WriteAt("__", x, y, ConsoleColor.Blue);
                        WriteAt("_  (  )", x - 4, y + 1, ConsoleColor.Blue);
                        WriteAt("´ `  /´\\\\", x - 5, y + 2, ConsoleColor.Blue);
                        WriteAt("°°", x - 2, y + 2, ConsoleColor.Magenta);
                        WriteAt("`  ``", x, y + 3, ConsoleColor.Blue);
                        break;
                    case 2:
                        WriteAt("__", x, y, ConsoleColor.Blue);
                        WriteAt("─. (  )", x - 4, y + 1, ConsoleColor.Blue);
                        WriteAt("(`´\\\\", x - 1, y + 2, ConsoleColor.Blue);
                        WriteAt("°", x - 2, y + 2, ConsoleColor.Magenta);
                        WriteAt("' `", x + 2, y + 3, ConsoleColor.Blue);
                        break;
                    case 3:
                        WriteAt("__", x, y, ConsoleColor.Blue);
                        WriteAt("`\\_(  )", x - 4, y + 1, ConsoleColor.Blue);
                        WriteAt("`´\\\\", x, y + 2, ConsoleColor.Blue);
                        WriteAt("°°", x - 2, y + 2, ConsoleColor.Magenta);
                        WriteAt("' `", x + 2, y + 3, ConsoleColor.Blue);
                        break;
                    case 4:
                        WriteAt(", __", x - 2, y, ConsoleColor.Blue);
                        WriteAt("(\\(  )", x - 3, y + 1, ConsoleColor.Blue);
                        WriteAt("`´)\\", x, y + 2, ConsoleColor.Blue);
                        WriteAt("°°", x - 2, y + 2, ConsoleColor.Magenta);
                        WriteAt("´ '", x - 1, y + 3, ConsoleColor.Blue);
                        break;
                    case 5:
                        WriteAt(",,__", x - 2, y, ConsoleColor.Blue);
                        WriteAt("(((  )", x - 3, y + 1, ConsoleColor.Blue);
                        WriteAt("`´)\\", x, y + 2, ConsoleColor.Blue);
                        WriteAt("°°", x - 2, y + 2, ConsoleColor.Magenta);
                        WriteAt("´ '", x + 1, y + 3, ConsoleColor.Blue);
                        break;
                    case 6:
                        WriteAt(",´/__", x - 3, y, ConsoleColor.Blue);
                        WriteAt("/ .(  )", x - 4, y + 1, ConsoleColor.Blue);
                        WriteAt("(  |  ´\\\\", x - 5, y + 2, ConsoleColor.Blue);
                        WriteAt("\\ '   ' `", x - 4, y + 3, ConsoleColor.Blue);
                        WriteAt("``", x - 3, y + 4, ConsoleColor.Blue);
                        break;
                    case 7:
                        WriteAt("__", x, y, ConsoleColor.Blue);
                        WriteAt("(  )", x - 1, y + 1, ConsoleColor.Blue);
                        WriteAt(",  .´\\\\", x - 3, y + 2, ConsoleColor.Blue);
                        WriteAt("°°", x - 2, y + 2, ConsoleColor.Magenta);
                        WriteAt("\\  |  ``", x - 3, y + 3, ConsoleColor.Blue);
                        break;
                    default:
                        EnemigoBase(monstruo, x, y);
                        break;
                }
                await Task.Delay(40);

            }
        }
        else
        {

        }
    }
}