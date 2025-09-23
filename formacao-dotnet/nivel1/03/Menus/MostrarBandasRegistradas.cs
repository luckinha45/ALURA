namespace Aula03.Menus;

internal class MostrarBandasRegistradas : Menu
{
    internal override void Executar(Dictionary<string, Models.Banda> bandas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
    }
}