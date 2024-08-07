public class Combate(){
    public static async void PeleaTurnos(ObtenerPersonaje.Players jugador, string enemigo){
       ObtenerAPI.Monsters monstruo = await ObtenerAPI.ObtenerMonstruo(enemigo);
       Console.Clear();
            while(true){
            switch(monstruo.name){
                case "Giant Spider":
                Mostrar.EnemigoBase(monstruo.name, 34,10);
                break;
            }
            Mostrar.AtaquePersonaje(jugador.clase, 20, 12);
                await Task.Delay(1000);
            Mostrar.AtaqueEnemigo(monstruo.name, 50,12);
                await Task.Delay(1000);


            }       

    //    if(jugador.vida==0){
    //     //perdio
    //    }else{
    //     //gano y recompensa
    //    }
    }



}