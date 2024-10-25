using System.Text.Json;

namespace ScreenSound.Modelos;

public class MusicasPreferidas
{
    public string? Nome { get; }
    public List<Musica> ListaDeMusicasFavorita { get; }

    public MusicasPreferidas(string nome)
    {
        this.Nome = nome;
        ListaDeMusicasFavorita = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavorita.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        ListaDeMusicasFavorita.ForEach(musica => Console.WriteLine($"- {musica.Nome} de {musica.Artista}"));
        Console.WriteLine("");
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavorita
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine("O arquivo Json foi criado com sucesso!");
    }
}