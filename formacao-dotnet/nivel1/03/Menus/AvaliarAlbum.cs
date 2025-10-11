using Aula03.Models;

namespace Aula03.Menus;

class AvaliarAlbum : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandas)
    {
        Console.Clear();
        Menu.ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que possui o album: ");
        string nomeBanda = Console.ReadLine()!;
        
        Banda banda;

        if (bandas.ContainsKey(nomeBanda))
        {
            banda = bandas[nomeBanda];
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
            return;
        }

        if (banda.Albuns.Count == 0)
        {
            Console.WriteLine($"\nA banda {nomeBanda} não possui álbuns cadastrados!");
            return;
        }

        Console.Write("Digite o nome do album: ");
        string nomeAlbum = Console.ReadLine()!;

        Console.Write($"Qual nota o album {nomeAlbum} da banda {nomeBanda} merece: ");

        Models.Avaliacao av;
        try { av = Models.Avaliacao.Parse(Console.ReadLine()!); }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro. {ex.Message}");
            return;
        }

        if (banda.Albuns.ContainsKey(nomeAlbum))
        {
            Album album = banda.Albuns[nomeAlbum];
            album.AdicionarNota(av);
            Console.WriteLine($"\nNota {av.Nota} foi registrada com sucesso para o album {nomeAlbum} da banda {nomeBanda}");
        }
        else
        {
            Console.WriteLine($"\nO album {nomeAlbum} não foi encontrado na discografia da banda {nomeBanda}!");
        }
    }
}