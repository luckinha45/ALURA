class Episodio
{
    public readonly int duracao; //segundos
    public readonly int ordem;
    public readonly string titulo;
    public string Resumo => $"{ordem}. {titulo} ({string.Join(", ", convidados)}) - {duracao} segundos";
    public List<string> convidados;

    public Episodio(string titulo = "", int ordem = 0, int duracao = 0, List<string>? convidados = null)
    {
        this.titulo = titulo;
        this.ordem = ordem;
        this.duracao = duracao;
        this.convidados = convidados ?? new List<string>();
    }

    public void AdicionarConvidado(string nome)
    {
        this.convidados.Add(nome);
    }
}