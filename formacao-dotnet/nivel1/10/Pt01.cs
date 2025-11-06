using System.Collections;

namespace Aula10;

internal class Pt01
{
    public Pt01()
    {
        var i = testeYield();

        foreach (var a in i)
        {
            Console.WriteLine(a);
        }
    }

    public IEnumerable<int> testeYield()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
        yield return 6;
    }
}


internal class DiasDaSemanaEnumerator : IEnumerator<string>
{
    private int idx;
    private string[] dias;

    public DiasDaSemanaEnumerator(string[] dias)
    {
        this.dias = dias;
        idx = -1;
    }

    public string Current => dias[idx];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        idx++;
        return idx < dias.Length;
    }

    public void Reset()
    {
        idx = -1;
    }
}

internal class DiasDaSemana : IEnumerable<string>
{
    private string[] dias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado" };

    public IEnumerator<string> GetEnumerator()
    {
        return new DiasDaSemanaEnumerator(dias);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}