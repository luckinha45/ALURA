namespace Aula03.Menus;

internal class AvaliarBanda : Menu
{
    internal override void Executar(Dictionary<string, Models.Banda> bandas)
    {
        Console.Clear();
        Menu.ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual nota a banda {nomeDaBanda} merece: ");

            Models.Avaliacao av;
            try
            {
                av = Models.Avaliacao.Parse(Console.ReadLine()!);
                bandas[nomeDaBanda].AdicionarNota(av);
                Console.WriteLine($"\nA nota {av.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro. {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }
    }
}