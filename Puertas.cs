public class EleccionPuerta(){
    public static void EscogerProbabilidad(ObtenerPersonaje.Players jugador){
        var seed = Environment.TickCount;
        var random = new Random(seed);
        var value = random.Next(1,3);
        // if(value == 2){
        //     //recompensa
        // }else{
            //pelea
            // value=random.Next(1,2);
            // string enemigo;
            // if(value==2){
            //     //pelea con araña
            //     enemigo = "giant-spider";
            // }else{
            //     //pelea con ejambre de mosquitos
            //     enemigo = "swarm-of-insects";
            // }

            Combate.PeleaTurnos(jugador, "giant-spider");

        // }
    }



}