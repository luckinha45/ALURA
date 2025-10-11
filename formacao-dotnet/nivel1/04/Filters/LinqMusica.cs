namespace Aula04.Filters;

internal class LinqMusica
{
    public static void FiltarMusicasPorArtistas(List<Models.Musica> musicas, string artista)
    {
        var artistas = musicas
            .Where(m => m.Artista == artista)
            .ToList();


        foreach (var a in artistas)
        {
            a.ExibirDetalhes();
            Console.WriteLine("---------------------------");
        }
    }
}