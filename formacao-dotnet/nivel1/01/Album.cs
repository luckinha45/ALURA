class Album
{
    private string nome;
    private string artista;
    private int DuracaoTotal => musicas.Sum(m => m.Duracao);
    private string DuracaoTotalFormatada => Globals.FormataDuracao(DuracaoTotal);
    private List<Musica> musicas;

    public Album(string nome = "", string artista = "")
    {
        this.nome = nome;
        this.artista = artista;
        this.musicas = new List<Musica>();
    }

    public void AddMusica(Musica m)
    {
        if (m.Artista.ToUpper() == this.artista.ToUpper())
        {
            this.musicas.Add(m);
        }
        else
        {
            throw new Exception($"A música ({m.Nome}) não pôde ser adicionada ao álbum ({this.nome}). Artista diferente.");
        }
    }

    public void PrintMusicas()
    {
        Console.WriteLine($"Músicas do álbum {this.nome} - {this.artista}:");
        for (int i = 0; i < this.musicas.Count; i++)
        {
            Console.WriteLine($"\t{i + 1} - {this.musicas[i].Nome} - {this.musicas[i].DurationFormatada}");
        }
        Console.WriteLine($"Duração total: {this.DuracaoTotalFormatada}");
    }
}