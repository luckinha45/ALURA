using System.Collections;

namespace Aula10.Pt01;

internal class Parte01
{
    public Parte01()
    {
        var diasSemana = new ArrayList { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", 10 };
        
        foreach (var el in diasSemana)
        {
            Console.WriteLine(el.GetType() == typeof(int));
        }
    }
}