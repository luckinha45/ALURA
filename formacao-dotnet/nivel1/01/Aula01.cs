class Aula01
{
    public static void Executar()
    {
        // generos
        var rock = new Genero("Rock");
        var alternativo = new Genero("Alternativo");
        var progressivo = new Genero("Progressivo");

        var originOfSymmetry = new Album("Origin of Symmetry", "Muse");

        var newBorn = new Musica("New Born", "Muse", Globals.DuracaoToSecs(6, 0), new Genero[] { rock, alternativo }, true);
        var citizenErased = new Musica("Citizen Erased", "Muse", Globals.DuracaoToSecs(7, 21), new Genero[] { rock, progressivo }, false);
        var spaceDementia = new Musica("Space Dementia", "Muse", Globals.DuracaoToSecs(6, 22), new Genero[] { rock, progressivo }, true);

        spaceDementia.ExbirFichaTecnica();
        // originOfSymmetry.AddMusica(newBorn);
        // originOfSymmetry.AddMusica(citizenErased);
        // originOfSymmetry.AddMusica(spaceDementia);
        // originOfSymmetry.PrintMusicas();
    }
}
