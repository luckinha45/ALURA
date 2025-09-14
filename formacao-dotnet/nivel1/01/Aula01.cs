class Aula01
{
    public static void Executar()
    {
        // generos
        Genero rock = new Genero("Rock");
        Genero alternativo = new Genero("Alternativo");
        Genero progressivo = new Genero("Progressivo");
        Genero symphoRock = new Genero("Rock Simfonico");

        Artista muse = new Artista("Muse", new List<Album>());
        Artista qotsa = new Artista("Queens of the Stone Age", new List<Album>());

        // musicas
        Musica newBorn = new Musica("New Born", muse, Globals.DuracaoToSecs(6, 0), [rock, alternativo], true);
        Musica citErazed = new Musica("Citizen Erased", muse, Globals.DuracaoToSecs(7, 11), [rock, progressivo], false);
        Musica spaceDementia = new Musica("Space Dementia", muse, Globals.DuracaoToSecs(6, 22), [rock, progressivo], true);

        Musica explorers = new Musica("Explorers", muse, Globals.DuracaoToSecs(5, 48), [progressivo, symphoRock], true);
        Musica saveMe = new Musica("Save Me", muse, Globals.DuracaoToSecs(5, 9), [progressivo, alternativo], false);

        newBorn.ExbirFichaTecnica();
        Console.WriteLine("");

        // albuns
        Album originOfSymmetry = new Album("Origin of Symmetry", muse);
        originOfSymmetry.AddMusica(newBorn);
        originOfSymmetry.AddMusica(citErazed);
        originOfSymmetry.AddMusica(spaceDementia);

        originOfSymmetry.PrintMusicas();
        Console.WriteLine("");

        Album secondLaw = new Album("2nd Law", muse);
        secondLaw.AddMusica(explorers);
        secondLaw.AddMusica(saveMe);

        // artista
        muse.AddAlbum(originOfSymmetry);
        muse.AddAlbum(secondLaw);
        muse.ListaAlbuns();
        Console.WriteLine("");
    }
}
