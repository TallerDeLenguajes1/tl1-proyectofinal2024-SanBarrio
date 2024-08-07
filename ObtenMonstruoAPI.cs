using System.Text.Json.Serialization;
using System.Text.Json;

public class ObtenerAPI
{

    public static async Task<Monsters> ObtenerMonstruo(string criatura)
    {
        var url = "https://www.dnd5eapi.co/api/monsters/" + criatura;

        try
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string contenido = await response.Content.ReadAsStringAsync();
            Monsters monstruo;
           monstruo = JsonSerializer.Deserialize<Monsters>(contenido);
            return monstruo;
        }
        catch (HttpRequestException)
        {
            Console.WriteLine("ERROR: No se pudo acceder a la API.");
            throw;
        }
    }
    public class Monsters
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("hit_points")]
        public int hit_points { get; set; }
        [JsonPropertyName("strength")]
        public int strength { get; set; }


    }



}