using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LingFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenros = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenros)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
