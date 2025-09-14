class Aula01
{
    public static void Executar()
    {
        var originOfSymmetry = new Album("Origin of Symmetry", "Muse");

        var newBorn = new Musica("New Born", "Muse", Globals.DuracaoToSecs(6, 0), new string[] { "Rock", "Alternativo" }, true);
        var citizenErased = new Musica("Citizen Erased", "Muse", Globals.DuracaoToSecs(7, 21), new string[] { "Rock", "Progressivo" }, false);
        var spaceDementia = new Musica("Space Dementia", "Muse", Globals.DuracaoToSecs(6, 22), new string[] { "Rock", "Progressivo" }, true);

        originOfSymmetry.AddMusica(newBorn);
        originOfSymmetry.AddMusica(citizenErased);
        originOfSymmetry.AddMusica(spaceDementia);
        originOfSymmetry.PrintMusicas();
    }
}
