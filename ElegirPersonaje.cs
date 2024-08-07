using System.Text.Json.Serialization;
using System.Text.Json;

public class ObtenerPersonaje
{

    public static Players SeleccionarPersonaje()
    {
        string fileName;
        string jsonString;
        fileName = Path.GetFullPath("../../../Personajes/Arquero.json");
        jsonString = File.ReadAllText(fileName);
        Players Arquero = JsonSerializer.Deserialize<Players>(jsonString);
        fileName = Path.GetFullPath("../../../Personajes/Caballero.json");
        jsonString = File.ReadAllText(fileName);
        Players Caballero = JsonSerializer.Deserialize<Players>(jsonString);
        fileName = Path.GetFullPath("../../../Personajes/Mago.json");
        jsonString = File.ReadAllText(fileName);
        Players Mago = JsonSerializer.Deserialize<Players>(jsonString);

        Console.Clear();
        Mostrar.WriteAt("----ELIGE TU PERSONAJE----", 30, 3, ConsoleColor.White);
        Mostrar.WriteAt("1. Nombre: " + Arquero.nombre, 11, 5, ConsoleColor.Green);
        Mostrar.WriteAt("Raza: " + Arquero.raza, 14, 6, ConsoleColor.White);
        Mostrar.WriteAt("Clase: " + Arquero.clase, 14, 7, ConsoleColor.White);
        Mostrar.WriteAt("Edad: " + Arquero.edad, 14, 8, ConsoleColor.White);
        Mostrar.WriteAt("Vida: " + Arquero.vida.ToString(), 14, 9, ConsoleColor.White);
        Mostrar.WriteAt("Fuerza: " + Arquero.fuerza.ToString(), 14, 10, ConsoleColor.White);
        Mostrar.WriteAt("Armadura: " + Arquero.defensa.ToString(), 14, 11, ConsoleColor.White);

        Mostrar.WriteAt("2. Nombre: " + Caballero.nombre, 45 , 5, ConsoleColor.Blue);
        Mostrar.WriteAt("Raza: " + Caballero.raza, 48, 6, ConsoleColor.White);
        Mostrar.WriteAt("Clase: " + Caballero.clase, 48, 7, ConsoleColor.White);
        Mostrar.WriteAt("Edad: " + Caballero.edad, 48, 8, ConsoleColor.White);
        Mostrar.WriteAt("Vida: " + Caballero.vida.ToString(), 48, 9, ConsoleColor.White);
        Mostrar.WriteAt("Fuerza: " + Caballero.fuerza.ToString(), 48, 10, ConsoleColor.White);
        Mostrar.WriteAt("Armadura: " + Caballero.defensa.ToString(), 48, 11, ConsoleColor.White);

        Mostrar.WriteAt("3. Nombre: " + Mago.nombre, 25, 13, ConsoleColor.Magenta);
        Mostrar.WriteAt("Raza: " + Mago.raza, 28, 14, ConsoleColor.White);
        Mostrar.WriteAt("Clase: " + Mago.clase, 28, 15, ConsoleColor.White);
        Mostrar.WriteAt("Edad: " + Mago.edad, 28, 16, ConsoleColor.White);
        Mostrar.WriteAt("Vida: " + Mago.vida.ToString(), 28, 17, ConsoleColor.White);
        Mostrar.WriteAt("Fuerza: " + Mago.fuerza.ToString(), 28, 18, ConsoleColor.White);
        Mostrar.WriteAt("Armadura: " + Mago.defensa.ToString(), 28, 19, ConsoleColor.White);

        Mostrar.WriteAt("Eliga el numero de su personaje: ", 33, 22, ConsoleColor.White);
        int i;
        int.TryParse(Console.ReadLine(), out i);
        Players JugadorSeleccionado = new Players();
        switch(i){
            case 1:
                JugadorSeleccionado = Arquero;
                break;
            case 2:
                JugadorSeleccionado = Caballero;
                break;
            case 3:
                JugadorSeleccionado = Mago;
                break;
        }
        return JugadorSeleccionado;

    }

    public class Players
    {
        [JsonPropertyName("Nombre")]
        public string nombre { get; set; }
        [JsonPropertyName("Descripcion")]
        public string descripcion { get; set; }
        [JsonPropertyName("Raza")]
        public string raza { get; set; }
        [JsonPropertyName("Edad")]
        public string edad { get; set; }
        [JsonPropertyName("Clase")]
        public string clase { get; set; }
        [JsonPropertyName("Vida")]
        public int vida { get; set; }
        [JsonPropertyName("Fuerza")]
        public int fuerza { get; set; }
        [JsonPropertyName("Defensa")]
        public int defensa { get; set; }


    }
}