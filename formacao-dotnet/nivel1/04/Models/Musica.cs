using System.Text.Json.Serialization;
using Microsoft.VisualBasic;

namespace Aula04.Models;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; init; }

    [JsonPropertyName("artist")]
    public string? Artista { get; init; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; init; }

    [JsonPropertyName("genre")]
    public string? Genero { get; init; }

    [JsonPropertyName("key")]
    public int Tom { get; init; }

    public string TomExt => this.Tom switch
    {
        0 => "C",
        1 => "C#",
        2 => "D",
        3 => "D#",
        4 => "E",
        5 => "F",
        6 => "F#",
        7 => "G",
        8 => "G#",
        9 => "A",
        10 => "A#",
        11 => "B",
        _ => "DESCONHECIDO"
    };

    public List<string> ListGenero => this.Genero!.Split(',').Select(g => g.Trim().ToUpper()).ToList();

    public string DuracaoExtenso => TimeSpan.FromMilliseconds(this.Duracao).ToString(@"mm\:ss\.fff");

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Artista: {this.Artista}");
        Console.WriteLine($"Duração: {this.DuracaoExtenso}");
        Console.WriteLine($"Gênero: {this.Genero}");
        Console.WriteLine($"Tom: {this.TomExt}");
    }

}