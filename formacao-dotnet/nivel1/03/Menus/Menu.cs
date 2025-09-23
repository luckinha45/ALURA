using Aula03.Models;

namespace Aula03.Menus;

internal abstract class Menu
{
    protected static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    internal abstract void Executar(Dictionary<string, Banda> bandasRegistradas);
}