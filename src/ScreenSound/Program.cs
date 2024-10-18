using ScreenSound.Filtros;
using ScreenSound.Modelos;
using System.Text.Json;

namespace ScreenSound;

internal class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string endPoint = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
                string respota = await client.GetStringAsync(endPoint);
                var musicas = JsonSerializer.Deserialize<List<Musica>>(respota);

                LingFilter.FiltrarTodosOsGenerosMusicais(musicas);

                //if (musicas != null && musicas.Count > 0)
                //    musicas.ForEach(m => m.ExibirDetalhesDaMusica());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Temos um problema: {ex.Message}");
            }
        }
    }
}
