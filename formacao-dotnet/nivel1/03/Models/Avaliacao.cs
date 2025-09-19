namespace Aula03.Models;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public static Avaliacao Parse(string input)
    {
        if (int.TryParse(input, out int nota))
        {
            if (nota < 0 || nota > 10)
            {
                throw new Exception("A nota deve estar entre 0 e 10.");
            }
            return new Avaliacao(nota);
        }

        throw new Exception("A nota deve ser um número inteiro.");
    }

}
