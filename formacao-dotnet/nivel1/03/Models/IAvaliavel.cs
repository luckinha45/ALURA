namespace Aula03.Models;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);

    double Media { get; }
}
