public class EleccionPuerta()
{
    public static async Task<ObtenerPersonaje.Players> EscogerProbabilidad(ObtenerPersonaje.Players jugador)
    {
        Console.Clear();
        var seed = Environment.TickCount;
        var random = new Random(seed);
        var value = random.Next(1, 4); ;
         string Historia;
        if (value == 2)
        {
            //recompensa
            Console.ForegroundColor=ConsoleColor.Green;
            Historia = "Tuviste suerte esta vez... Obtienes una recompensa!:";
            for (int k = 0; k < Historia.Length; k++)
            {
                Console.Write(Historia[k]);
                await Task.Delay(30);
            }
                await Task.Delay(700);
            Mostrar.RecompensaCofre(35, 6);
            Mostrar.WriteAt("Elije un numero para tu recompensa: ", 39, 15, ConsoleColor.DarkGreen);
            int i;
            int.TryParse(Console.ReadLine(), out i);
            switch (i)
            {
                case 1:
                    jugador.vidaMax += 20;
                    jugador.vida += 20;
                    break;
                case 2:
                    jugador.fuerza += 3;
                    break;
                case 3:
                    jugador.defensa += 1;
                    break;
            }
        }
        else
        {

           
            //pelea
            value = random.Next(1, 10);
            string enemigo;
            if ((value % 2) == 0)
            {
                //pelea con araña
                enemigo = "giant-spider";
            }
            else
            {
                //pelea con ejambre de mosquitos
                enemigo = "swarm-of-insects";
            }
            Console.ForegroundColor=ConsoleColor.Red;

            Historia = "No tuviste suerte esta vez, te enfrentas contra.....¡"+enemigo+"!";
            for (int k = 0; k < Historia.Length; k++)
            {
                Console.Write(Historia[k]);
                await Task.Delay(30);
            }
            await Task.Delay(700);
            int vida = await Combate.PeleaTurnos(jugador, enemigo);
            await Task.Delay(1000);
            if (vida > 0)
            {
                Console.Clear();
                Mostrar.Ganador();
                Mostrar.WriteAt("Dado a tu desempeño la mazmorra desea darte una recompensa", 27, 15, ConsoleColor.Green);
                await Task.Delay(2000);
                Console.Clear();
                Mostrar.RecompensaCofre(20, 6);
                Mostrar.RecompensaBatalla(77, 6);
                Mostrar.WriteAt("Elije un numero para tu recompensa: ", 30, 15, ConsoleColor.DarkGreen);

                int i;
                int.TryParse(Console.ReadLine(), out i);
                switch (i)
                {
                    case 1:
                        jugador.vidaMax += 20;
                        jugador.vida += 20;
                        break;
                    case 2:
                        jugador.fuerza += 3;
                        break;
                    case 3:
                        jugador.defensa += 1;
                        break;
                    case 4:
                        jugador.vida = jugador.vidaMax;
                        break;
                }
            }else{
                Console.Clear();
                Mostrar.Perdedor();
                await Task.Delay(1000);
                Console.Clear();
            }

        }
        return jugador;
    }



}