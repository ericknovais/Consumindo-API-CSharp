using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

public class LingOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas, bool ehDescendente = false)
    {

        List<string>? artistasOrdenado = new List<string>();
        if (!ehDescendente)
            artistasOrdenado = musicas.OrderBy(musica => musica.Artista)
                .Select(musica => musica.Artista).Distinct().ToList();
        else
            artistasOrdenado = musicas.OrderByDescending(musica => musica.Artista)
                .Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine("Lista de Artistas ordenados");
        foreach (var artista in artistasOrdenado)
            Console.WriteLine($"- {artista}");
    }
}
