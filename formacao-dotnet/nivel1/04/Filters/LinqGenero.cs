namespace Aula04.Filters;

internal class LinqFilter
{
    public static void FiltarTodosGeneros(List<Models.Musica> musicas)
    {
        var generos = musicas
            .Select(m => m.ListGenero)
            .Aggregate((currGenres, genres) => currGenres.Concat(genres).ToList())
            .Distinct()
            .Order()
            .ToList();

        foreach (var g in generos)
        {
            Console.WriteLine(g);
        }
    }
}
