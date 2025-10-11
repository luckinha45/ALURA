using System.Text.Json.Serialization;

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

    public List<string> ListGenero => this.Genero!.Split(',').Select(g => g.Trim().ToUpper()).ToList();

    public string DuracaoExtenso => TimeSpan.FromMilliseconds(this.Duracao).ToString(@"mm\:ss\.fff");

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Artista: {this.Artista}");
        Console.WriteLine($"Duração: {this.DuracaoExtenso}");
        Console.WriteLine($"Gênero: {this.Genero}");
    }

}