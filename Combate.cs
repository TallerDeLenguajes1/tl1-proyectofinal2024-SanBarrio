public class Combate()
{
    public static async Task<int> PeleaTurnos(ObtenerPersonaje.Players jugador, string enemigo)
    {
        ObtenerAPI.Monsters monstruo = await ObtenerAPI.ObtenerMonstruo(enemigo);
        Console.Clear();
            while (monstruo.hit_points > 0 || jugador.vida>0)
            {   
                Mostrar.WriteAt("Vida del Personaje: "+jugador.vida,30,20, ConsoleColor.Green);
                Mostrar.WriteAt("Vida del Enemigo: "+monstruo.hit_points,30,21, ConsoleColor.Red);
                Mostrar.EnemigoBase(monstruo.name, 50, 12);
                Mostrar.AtaquePersonaje(jugador.clase, 20, 12);
                if((monstruo.hit_points-jugador.fuerza)<0)break;
                else monstruo.hit_points-=jugador.fuerza;
                await Task.Delay(1000);
                Mostrar.WriteAt("Vida del Personaje: "+jugador.vida,30,20, ConsoleColor.Green);
                Mostrar.AtaqueEnemigo(monstruo.name, 50, 12);
                if((jugador.vida-monstruo.strength)<0)break;
                else jugador.vida-=monstruo.strength;
                await Task.Delay(1000);
                Mostrar.WriteAt("Vida del Enemigo: "+monstruo.hit_points,30,21, ConsoleColor.Red);

            }

            return jugador.vida;

    }



}