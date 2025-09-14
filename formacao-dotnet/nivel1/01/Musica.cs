class Musica
{
    public string Nome { get; }
    public string Artista { get; }
    public int Duracao { get; } //segundos
    private Genero[] generos;
    private bool disponivel;
    
    public string NomeArtista => $"{this.Nome} - {this.Artista}";

    public string DurationFormatada => Globals.FormataDuracao(Duracao);

    public Musica(string nome = "", string artista = "", int duracao = 0, Genero[]? generos = null, bool disponivel = false)
    {
        this.Nome = nome;
        this.Artista = artista;
        this.Duracao = duracao;
        this.generos = generos ?? new Genero[] { };
        this.disponivel = disponivel;
    }

    // object methods
    public void ExbirFichaTecnica()
    {
        Console.WriteLine($"Nome:       {this.Nome}");
        Console.WriteLine($"Artista:    {this.Artista}");
        Console.WriteLine($"Duração:    {this.Duracao} segundos");
        Console.WriteLine($"Gêneros:    {string.Join(", ", this.generos.Select(g => g.Nome))}");
        Console.WriteLine($"{(this.disponivel ? "Disponível no plano." : "Adquira no Plano+")}");
    }



    // overriden methods
    public override string ToString()
    {
        return this.Nome;
    }
}