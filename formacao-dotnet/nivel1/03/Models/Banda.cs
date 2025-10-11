namespace Aula03.Models;

internal class Banda : IAvaliavel
{
    public Dictionary<string, Album> Albuns { get; }
    private List<Avaliacao> notas = new();

    public Banda(string nome)
    {
        Nome = nome;
        Albuns = new Dictionary<string, Album>();
    }

    public string Nome { get; }
    public double Media => notas.Count > 0 ? notas.Average(a => a.Nota) : 0;

    public void AdicionarAlbum(Album album) 
    { 
        Albuns.Add(album.Nome, album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in Albuns.Values)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}