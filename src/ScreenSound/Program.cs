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
                List<Musica>? musicas = JsonSerializer.Deserialize<List<Musica>>(respota);
                musicas = musicas != null ? musicas : new List<Musica>();
                //LingFilter.FiltrarTodosOsGenerosMusicais(musicas);
                //LingOrder.ExibirListaDeArtistasOrdenados(musicas, ehDescendente: true);
                //LingFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");

                LingFilter.FiltrarMusicasDeUmArtista(musicas, "3 Doors Down");
                LingFilter.FiltarMusicasEmCSharp(musicas);
                //if (musicas != null && musicas.Count > 0)
                //    musicas.ForEach(m => m.ExibirDetalhesDaMusica());

                MusicasPreferidas musicasPreferidasErick = new MusicasPreferidas("Erick");
                for (int i = 0; i < 5; i++)
                    musicasPreferidasErick.AdicionarMusicasFavoritas(musicas[new Random().Next(1, 1999)]);

                musicasPreferidasErick.ExibirMusicasFavoritas();
                musicasPreferidasErick.GerarArquivoJson();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Temos um problema: {ex.Message}");
            }
        }
    }
}
