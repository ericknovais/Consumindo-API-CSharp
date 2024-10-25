using System.Text.Json.Serialization;

namespace ScreenSound.Modelos
{

    public class Musica
    {
        public Musica()
        {
            this.Artista = string.Empty;
            this.Nome = string.Empty;
            this.Duracao = 0;
            this.Genero = string.Empty;
        }

        [JsonPropertyName("artist")]
        public string Artista { get; set; }

        [JsonPropertyName("song")]
        public string Nome { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
            Console.WriteLine($"Gênero musical: {Genero}");
            Console.WriteLine("\n");
        }
    }
}