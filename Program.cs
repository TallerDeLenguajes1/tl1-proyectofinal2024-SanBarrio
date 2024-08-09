
using System;
using System.Dynamic;
using System.Net;
using System.Text;
using System.Threading.Tasks.Dataflow;
using Ganadores;
internal class Program
{
    static async Task Main(string[] args)
    {
        Console.Clear();
        Console.SetWindowSize(110,30);
        Console.CursorVisible = false;


        bool salir = false;


        while (!salir)
        {
            Console.Clear();
            Mostrar.Logo();
            Mostrar.WriteAt("1.Jugar", 40, 9, ConsoleColor.White);
            Mostrar.WriteAt("2.Historial", 40, 11, ConsoleColor.White);
            Mostrar.WriteAt("3.Salir", 40, 13, ConsoleColor.White);
            Mostrar.WriteAt("Escoja un numero: ", 35, 15, ConsoleColor.Red);

            int i;
            int.TryParse(Console.ReadLine(), out i);
            switch (i)
            {
                case 1:
                    ObtenerPersonaje.Players Jugador = ObtenerPersonaje.SeleccionarPersonaje();
                    Console.Clear();
                    string Historia = Jugador.descripcion + "\nYa como aventurero, elije una misión de completar una masmorra, 'JAJAJA esto será pan comido *exclamó*', lo que no sabía nuestro personaje es que esta misión era mas dificil de lo que parece....";
                    for (int k = 0; k < Historia.Length; k++)
                    {
                        Console.Write(Historia[k]);
                        await Task.Delay(28);
                    }
                    await Task.Delay(1200);

                    Console.Clear();
                    Mostrar.WriteAt("Iniciando Partida...", 30, 10, ConsoleColor.Red);
                    await Task.Delay(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Historia = "Mientras avanza en la mazmorra, se encuentra con 3 puertas, sin saber que hacer, decide buscar algo para guiarse, en lo que se topa con un cartel 'Oh osado aventurero, para seguir avanzando debes confiar en la probabilidad, una de estas puertas tiene una recompensa, pero las otras tendran una batalla contra una criatura de la mazmorra', sin saber que mas hacer, el aventurero decide confiar en su suerte...";
                    for (int k = 0; k < Historia.Length; k++)
                    {
                        Console.Write(Historia[k]);
                        await Task.Delay(30);
                    }
                    await Task.Delay(1700);
                    for (int j = 0; j < 5; j++)
                    {

                        Mostrar.SeleccionPuerta();
                        await Task.Delay(100);
                        Jugador = await EleccionPuerta.EscogerProbabilidad(Jugador);

                        if (Jugador.vida <= 0)
                        {
                            Console.Clear();
                            Historia = "No pudiste completar con exito la mazmorra, intentalo en la proxima vida";
                            for (int k = 0; k < Historia.Length; k++)
                            {
                                Console.Write(Historia[k]);
                                await Task.Delay(30);
                            }
                            await Task.Delay(1000);
                            break;
                        }
                    }
                    Console.Clear();
                    Historia = "Estas en la ultima habitación de la mazmorra, ya no hay puertas para escoger, solo hay una. Te adentras y... oh sorpresa! ES EL JEFE FINAL 'EL LICH'";
                    for (int k = 0; k < Historia.Length; k++)
                    {
                        Console.Write(Historia[k]);
                        await Task.Delay(30);
                    }
                    await Task.Delay(1000);
                    Jugador.vida = await Combate.PeleaTurnos(Jugador, "lich");
                    await Task.Delay(1000);
                    if (Jugador.vida <= 0)
                    {
                        Console.Clear();
                        Historia = "No pudiste vencer al Jefe final lamentablemente, intentalo en la proxima vida";
                        for (int k = 0; k < Historia.Length; k++)
                        {
                            Console.Write(Historia[k]);
                            await Task.Delay(30);
                        }
                        await Task.Delay(2000);
                        Console.Clear();

                    }
                    else
                    {
                        Console.Clear();
                        Historia = "Pudiste vencer al Jefe final, que alegria! Ahora puedes volver al gremio con la cabeza en alto, Aventurero!";
                        for (int k = 0; k < Historia.Length; k++)
                        {
                            Console.Write(Historia[k]);
                            await Task.Delay(30);
                        }
                        await Task.Delay(2000);
                        Console.Clear();
                        Mostrar.WriteAt("FIN", 50, 10, ConsoleColor.White);
                        await Task.Delay(2000);

                        Ganador ganadorPartida = new Ganador
                        {
                            Nombre = Jugador.nombre,
                            Fecha = DateTime.Now,
                        };
                        HistorialDeGanadores.GuardarGanador(ganadorPartida);  
                        Console.Clear();
                    }


                    break;
                case 2:
                     HistorialDeGanadores.MostrarHistorial(); 
                    break;
                case 3:
                    salir = true;
                    break;
            }
        }

    }

}