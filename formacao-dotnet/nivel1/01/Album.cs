namespace Aula01NS
{
    class Album
    {
        public readonly string titulo;
        public readonly Artista artista;
        private List<Musica> musicas;
        private int DuracaoTotal => musicas.Sum(m => m.duracao);
        public string DuracaoTotalFormatada => Globals.FormataDuracao(DuracaoTotal);

        public Album(string nome = "", Artista? artista = null)
        {
            this.titulo = nome;
            this.artista = artista ?? new Artista();
            this.musicas = new List<Musica>();
        }

        public void AddMusica(Musica m)
        {
            if (m.artista == this.artista)
            {
                this.musicas.Add(m);
            }
            else
            {
                throw new Exception($"A música ({m.faixa}) não pôde ser adicionada ao álbum ({this.titulo}). Artistas diferentes.");
            }
        }

        public void PrintMusicas()
        {
            Console.WriteLine($"Músicas do álbum {this.titulo} - {this.artista}:");
            for (int i = 0; i < this.musicas.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {this.musicas[i].faixa} - {this.musicas[i].DurationFormatada}");
            }
            Console.WriteLine($"Duração total: {this.DuracaoTotalFormatada}");
        }
    }
}
    