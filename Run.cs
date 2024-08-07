namespace Start
{

    using System.Text;
    using System.Media;
    using System.Text.Json.Serialization;
    using System.Text.Json;
  
    public class ObtenerAPI
    {

        public static async Task ObtenerMonstruo(string criatura)
        {
            var url = "https://www.dnd5eapi.co/api/monsters/"+criatura; //Obtenemos los primeros 5 planetas.
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                Monsters monstruo;
                monstruo = JsonSerializer.Deserialize<Monsters>(content);
                
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("ERROR: No se pudo acceder a la API.");
                throw;
            }
        }

        public class Monsters
        {
            [JsonPropertyName("index")]
            public string index { get; set; }
            [JsonPropertyName("hit_points")]
            public int hit_points { get; set; }
            [JsonPropertyName("strength")]
            public int strength { get; set; }


        }

        

    }

    string allWarriorsPaths[] = ; 
}