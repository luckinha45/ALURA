namespace Aula04.Filters;

internal class LinqArtista
{
    public static void SelectSorted(List<Models.Musica> musicas, SortBy sort)
    {
        List<string?>? artistas = null;

        if (sort == SortBy.asc)
        {
            artistas = musicas
                .Select(m => m.Artista)
                .Distinct()
                .Order()
                .ToList();
        }
        else
        {
            artistas = musicas
                .Select(m => m.Artista)
                .Distinct()
                .OrderDescending()
                .ToList();
        }

        foreach (var a in artistas)
        {
            Console.WriteLine(a);
        }
    }

    public static void SelectByGenero(List<Models.Musica> musicas, string genero)
    {
        var artistas = musicas
        .Where(m => m.ListGenero.Contains(genero.ToUpper()))
        .Select(m => m.Artista)
        .Distinct()
        .Order()
        .ToList();

        foreach(var a in artistas)
        {
            Console.WriteLine(a);
        }
    }
}