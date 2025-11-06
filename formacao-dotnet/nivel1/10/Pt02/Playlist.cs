using System.Collections;

namespace Aula10.Pt02;

internal class Playlist : ICollection<Musica>
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; set; }

    public int Count => musicas.Count();

    public bool IsReadOnly => false;

    public Musica? SearchByTitulo(string titulo)
    {
        var result = musicas.Where(m => m.Titulo.Equals(titulo));

        if (result.Any()) return result.First();
        else return null;
    }

    public void RemoveByTitulo(string titulo)
    {
        var m = this.SearchByTitulo(titulo);

        if (m != null) this.Remove(m);
    }

    public Musica? GetRandom()
    {
        if (!this.musicas.Any()) return null;

        var rng = new Random();
        var randIdx = rng.Next(this.Count);
        return musicas[randIdx];
    }

    enum SortOn { titulo, duracao, artista }

    public void SortBy(SortOn type)
    {
        musicas = musicas.OrderBy(m=>m.Duracao).ToList();
    }

    public void Add(Musica item)
    {
        musicas.Add(item);
    }

    public void Clear()
    {
        musicas.Clear();
    }

    public bool Contains(Musica item)
    {
        return musicas.Contains(item);
    }

    public void CopyTo(Musica[] array, int arrayIndex)
    {
        musicas.CopyTo(array, arrayIndex);
    }

    public bool Remove(Musica item)
    {
        return musicas.Remove(item);
    }

    public IEnumerator<Musica> GetEnumerator()
    {
        return musicas.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
