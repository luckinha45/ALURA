class Artista
{
    public readonly string nome;
    List<Album> albuns;

    public Artista(string nome = "", List<Album>? albuns = null)
    {
        this.nome = nome;
        this.albuns = albuns ?? new List<Album>();
    }

    public void AddAlbum(Album album)
    {
        if (album.artista == this)
        {
            this.albuns.Add(album);
        }
        else
        {
            throw new Exception($"O álbum ({album.titulo}) não pôde ser adicionado ao artista ({this.nome}). Artistas diferentes.");
        }
    }

    public void ListaAlbuns()
    {
        Console.WriteLine($"Albuns de {this.nome}:");
        foreach (var a in this.albuns)
        {
            Console.WriteLine($"{a.titulo} - Duração: {a.DuracaoTotalFormatada}");
        }
    }


    // overriden methods
    public override string ToString()
    {
        return this.nome;
    }
}