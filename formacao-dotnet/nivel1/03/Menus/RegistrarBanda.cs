namespace Aula03.Menus;

internal class RegistrarBanda : Menu
{
    internal override void Executar(Dictionary<string, Models.Banda> bandas)
    {
        Console.Clear();
        Menu.ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandas.Add(nomeDaBanda, new Models.Banda(nomeDaBanda));
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    }
}