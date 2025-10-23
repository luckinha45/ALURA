using Aula01NS;

namespace Aula04.Filters;

internal class LinqMusica
{
    public static void SelectByArtistas(List<Models.Musica> musicas, string artista)
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

    public static Models.Musica? SelectByNome(List<Models.Musica> musicas, string nome)
    {
        return musicas.Find(m => m.Nome == nome);
    }

    public static void SelectByTom(List<Models.Musica> musicas, string tom)
    {
        var filtradas = musicas.FindAll(m => m.TomExt == tom);

        foreach (var musica in filtradas)
        {
            musica.ExibirDetalhes();
            Console.WriteLine("---------------------------");
        }
    }
}