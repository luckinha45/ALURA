namespace Aula03.Menus;

internal class ExibirDetalhes : Menu
{
    internal override void Executar(Dictionary<string, Models.Banda> bandas)
    {
        Console.Clear();
        Menu.ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandas.ContainsKey(nomeDaBanda))
        {
            Models.Banda banda = bandas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            /**
            * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            */
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }
    }
}