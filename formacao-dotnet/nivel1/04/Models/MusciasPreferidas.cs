using System.Text;
using System.Text.Json;

namespace Aula04.Models;

internal class MusciasPreferidas
{
    public string Nome { get; init; }
    public List<Musica> musicasFavs { get; init; }

    public MusciasPreferidas(string nome)
    {
        this.Nome = nome;
        this.musicasFavs = new();
    }

    public void AddMusciaFav(Musica? m)
    {
        if (m != null) this.musicasFavs.Add(m);
    }

    public void ExibMusicasFavs()
    {
        Console.WriteLine($"Musicas favoritas de {this.Nome}");
        foreach (var m in musicasFavs)
        {
            Console.WriteLine($"  - {m.Nome} | {m.Artista} | {m.Genero}");
        }
        Console.WriteLine();
    }

    public void ExportToJson()
    {
        var options = new JsonSerializerOptions
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        string json = JsonSerializer.Serialize(new
        {
            nome = this.Nome,
            musicas = this.musicasFavs
        }, options);

        string nomeArquivo = $"musicas_{this.Nome}.json";

        File.WriteAllText(".\\04\\"+nomeArquivo, json, Encoding.UTF8);
        Console.WriteLine("Musicas favoritas salva.");
    }
}