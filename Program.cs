
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
            Mostrar.WriteAt("1.Jugar", 40, 9, ConsoleColor.White);
            Mostrar.WriteAt("2.Salir", 40, 11, ConsoleColor.White);
            Mostrar.WriteAt("Escoja un numero: ", 35, 13, ConsoleColor.Red);

            int i;
            int.TryParse(Console.ReadLine(), out i);
            switch (i)
            {
                case 1:
                    ObtenerPersonaje.Players Jugador = ObtenerPersonaje.SeleccionarPersonaje();
                    for(int j=0; j<5; j++){
                    Mostrar.SeleccionPuerta();
                    await Task.Delay(80);
                    Jugador = await EleccionPuerta.EscogerProbabilidad(Jugador);

                    if(Jugador.vida < 0){
                        break;
                    }
                    }                   
                    
                     Console.ReadLine();
                    break;
                case 2:
                    salir = true;
                    break;
            }
        }

    }
    
}