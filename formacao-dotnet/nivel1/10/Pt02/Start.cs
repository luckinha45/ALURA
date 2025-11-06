namespace Aula10.Pt02;

internal class Start
{
    public Start()
    {
        var m1 = new Musica { Titulo = "Evening Star", Artista = "Tyr", Duracao = 300 };
        var m2 = new Musica { Titulo = "I Appear Missing", Artista = "Queens of the Stone Age", Duracao = 400 };
        var m3 = new Musica { Titulo = "The Heaviest Matter of the Universe", Artista = "Gojira", Duracao = 238 };

        var playlist = new Playlist { Nome = "Minhas Favoritas" };
        playlist.Add(m1);
        playlist.Add(m2);
        playlist.Add(m3);

        playlist.SortBy();
        ExibirPlaylist(playlist);
    }

    void ExibirPlaylist(Playlist playlist)
    {
        Console.WriteLine($"\nPlaylist: {playlist.Nome}");
        foreach (var musica in playlist)
        {
            Console.WriteLine($"\t- {musica}");
        }
    }
}