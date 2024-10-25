using ScreenSound.Modelos;

namespace ScreenSound.Filtros;
public class LingFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
            Console.WriteLine($"- {genero}");
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {

        List<string> artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).OrderBy(m => m.Artista).
        Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>>{genero}");
        foreach (var artistas in artistasPorGeneroMusical)
            Console.WriteLine($"- {artistas}");

    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicaDoArtista = musicas.Where(m => m.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicaDoArtista)
            Console.WriteLine($"- {musica.Nome}");

    }

    internal static void FiltarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmShasp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine("Musicas em C#");
        foreach (var musica in musicasEmShasp)
            Console.WriteLine($"- {musica}");
    }
}