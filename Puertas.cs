public class EleccionPuerta()
{
    public static async Task<ObtenerPersonaje.Players> EscogerProbabilidad(ObtenerPersonaje.Players jugador)
    {
        Console.Clear();
        var seed = Environment.TickCount;
        var random = new Random(seed);
        var value = random.Next(1, 3);;
        if (value == 2)
        {
            //recompensa
            Mostrar.RecompensaCofre(20, 6);
            Mostrar.WriteAt("Elije un numero para tu recompensa: ",30,15,ConsoleColor.DarkGreen);
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
                    jugador.defensa += 3;
                    break;
            }
        }
        else
        {

            //pelea
            value = random.Next(1, 10);
            string enemigo;
            if ((value%2)==0)
            {
                //pelea con araña
                enemigo = "giant-spider";
            }
            else
            {
                //pelea con ejambre de mosquitos
                enemigo = "swarm-of-insects";
            }

            int vida = await Combate.PeleaTurnos(jugador, enemigo);
            await Task.Delay(1000);
            Console.Clear();

            if (vida > 0)
            {
                jugador.vida=vida;
                Mostrar.RecompensaCofre(20, 6);
                Mostrar.RecompensaBatalla(70, 6);
            Mostrar.WriteAt("Elije un numero para tu recompensa: ",30,15,ConsoleColor.DarkGreen);

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
                        jugador.defensa += 3;
                        break;
                    case 4:
                        jugador.vida = jugador.vidaMax;
                        break;
                }
            }

        }
            return jugador;
    }



}