public class Combate()
{
    public static async Task<int> PeleaTurnos(ObtenerPersonaje.Players jugador, string enemigo)
    {
        ObtenerAPI.Monsters monstruo = await ObtenerAPI.ObtenerMonstruo(enemigo);
        Console.Clear();
        if(monstruo.name=="Lich"){
            monstruo.hit_points*=3;
        }else monstruo.hit_points*=2;
            monstruo.strength*=3;
            int vidaEnemigo = monstruo.hit_points;
        while (monstruo.hit_points > 0 && jugador.vida > 0)
        {
            Mostrar.WriteAt("                              ", 15, 17, ConsoleColor.White);
            Mostrar.WriteAt("                              ", 50, 17, ConsoleColor.White);
            Mostrar.WriteAt("Vida: " + jugador.vida + "/" + jugador.vidaMax, 15, 17, ConsoleColor.Green);
            Mostrar.WriteAt("Nombre: " + jugador.nombre, 15, 18, ConsoleColor.Green);
            Mostrar.WriteAt("Fuerza y Daño: " + jugador.fuerza, 15, 19, ConsoleColor.Green);
            Mostrar.WriteAt("Armadura: " + jugador.defensa, 15, 20, ConsoleColor.Green);

            Mostrar.WriteAt("Nombre: " + monstruo.name, 50, 18, ConsoleColor.Red);
            Mostrar.WriteAt("Fuerza: " + monstruo.strength, 50, 19, ConsoleColor.Red);
            Mostrar.WriteAt("Daño realizado(Fuerza Enemiga/Armadura): " + ((monstruo.strength/jugador.defensa)+1), 50, 20, ConsoleColor.Red);
            Mostrar.WriteAt("Vida: " + monstruo.hit_points + "/" + vidaEnemigo, 50, 17, ConsoleColor.Red);
            Mostrar.EnemigoBase(monstruo.name, 50, 13);
            Mostrar.AtaquePersonaje(jugador.clase, 20, 13);
            if ((monstruo.hit_points - jugador.fuerza) <= 0) break;
            else monstruo.hit_points -= jugador.fuerza;
            await Task.Delay(1000);
            Mostrar.WriteAt("                               ", 50, 17, ConsoleColor.White);
            Mostrar.WriteAt("Vida: " + monstruo.hit_points + "/" + vidaEnemigo, 50, 17, ConsoleColor.Red);
            Mostrar.AtaqueEnemigo(monstruo.name, 50, 13);
            if (jugador.vida - ((monstruo.strength/jugador.defensa)+1) <= 0){
            jugador.vida -= (monstruo.strength/jugador.defensa)+1;
            break;
            }
            else jugador.vida -= (monstruo.strength/jugador.defensa)+1;
            await Task.Delay(1000);
            Mostrar.WriteAt("                              ", 15, 17, ConsoleColor.White);
            Mostrar.WriteAt("Vida" + jugador.vida + "/" + jugador.vidaMax, 15, 17, ConsoleColor.Green);

        }

        return jugador.vida;

    }



}