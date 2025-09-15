namespace Aula01NS
{
    class Podcast
    {
        public readonly string host;
        public readonly string nome;
        List<Episodio> Episodios { get; }
        public int TotalEpisodios => this.Episodios.Count;

        public Podcast(string nome= "", string host= "", List<Episodio>? episodios = null)
        {
            this.nome = nome;
            this.host = host;
            this.Episodios = episodios ?? new List<Episodio>();
        }

        public void AddEpisodio(Episodio ep)
        {
            this.Episodios.Add(ep);
            this.Episodios.Sort((a, b) => a.ordem.CompareTo(b.ordem));
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast: {this.nome} - Host: {this.host}");
            foreach (Episodio ep in this.Episodios)
            {
                Console.WriteLine($"  {ep.Resumo}");
            }
            Console.WriteLine($"Total de Episódios: {this.TotalEpisodios}");
        }
    }
}