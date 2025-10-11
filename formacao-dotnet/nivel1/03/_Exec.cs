using Aula03.Models;

namespace Aula03;

class Exec
{
    static Dictionary<string, Models.Banda> bandasRegistradas = new();

    static public void Executar()
    {
        Models.Banda tyr = new Models.Banda("Tyr");
        tyr.AdicionarNota(new Avaliacao(10));
        tyr.AdicionarNota(new Avaliacao(9));
        tyr.AdicionarNota(new Avaliacao(6));
        Models.Banda sabaton = new Models.Banda("Sabaton");
        sabaton.AdicionarNota(new Avaliacao(8));
        sabaton.AdicionarNota(new Avaliacao(7));
        sabaton.AdicionarNota(new Avaliacao(9));

        bandasRegistradas.Add(tyr.Nome, tyr);
        bandasRegistradas.Add(sabaton.Nome, sabaton);

        ExibirOpcoesDoMenu();
    }

    static void ExibirLogo()
    {
        Console.WriteLine(@"

 _______  _______ _________ _______  _                 ______  _________ _______ 
(       )(  ____ \\__   __/(  ___  )( \      |\     /|(  __  \ \__   __/(  ___  )
| () () || (    \/   ) (   | (   ) || (      | )   ( || (  \  )   ) (   | (   ) |
| || || || (__       | |   | (___) || |      | |   | || |   ) |   | |   | |   | |
| |(_)| ||  __)      | |   |  ___  || |      | |   | || |   | |   | |   | |   | |
| |   | || (         | |   | (   ) || |      | |   | || |   ) |   | |   | |   | |
| )   ( || (____/\   | |   | )   ( || (____/\| (___) || (__/  )___) (___| (___) |
|/     \|(_______/   )_(   |/     \|(_______/(_______)(______/ \_______/(_______)
                                                                                 
");
        Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
    }

    static void ExibirOpcoesDoMenu()
    {
        Dictionary<string, Menus.Menu> menus = new()
        {
            { "1", new Menus.RegistrarBanda() },
            { "2", new Menus.RegistrarAlbum() },
            { "3", new Menus.MostrarBandasRegistradas() },
            { "4", new Menus.AvaliarBanda() },
            { "5", new Menus.AvaliarAlbum() },
            { "6", new Menus.ExibirDetalhes() }
        };

        while (true)
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para avaliar um álbum");
            Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;

            if (opcaoEscolhida == "0")
            {
                Console.WriteLine("Tchau tchau :)");
                return;
            }

            if (menus.ContainsKey(opcaoEscolhida))
            {
                menus[opcaoEscolhida].Executar(bandasRegistradas);
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
