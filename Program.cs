
using System;
using System.Dynamic;
using System.Net;
using System.Text;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.Clear();

        Console.CursorVisible = false;
       
        Mostrar.Logo();

        bool salir = false;


        while (!salir)
        {
            Mostrar.WriteAt("1.Jugar", 33, 9, ConsoleColor.White);
            Mostrar.WriteAt("2.Salir", 33, 11, ConsoleColor.White);
            Mostrar.WriteAt("Numero: ", 33, 14, ConsoleColor.Red);

            int i;
            int.TryParse(Console.ReadLine(), out i);
            switch (i)
            {
                case 1:
                    ObtenerPersonaje.Players Jugador = ObtenerPersonaje.SeleccionarPersonaje();
                    Mostrar.SeleccionPuerta();
                     Console.ReadLine();
                    break;
                case 2:
                    salir = true;
                    break;
            }
        }

    }
    
}