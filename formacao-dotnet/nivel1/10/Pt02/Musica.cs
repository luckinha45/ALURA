namespace Aula10.Pt02;

internal class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }

    public override string ToString()
    {
        return $"{Titulo} | {Artista} ({Duracao}s)";
    }
}