public class Combate(){
    public static async void PeleaTurnos(ObtenerPersonaje.Players jugador, string enemigo){
       ObtenerAPI.Monsters monstruo = await ObtenerAPI.ObtenerMonstruo(enemigo);

       while(jugador.vida!=0 || monstruo.hit_points!=0){

       }

       if(jugador.vida==0){
        //perdio
       }else{
        //gano y recompensa
       }
    }



}