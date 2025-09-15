namespace Aula01NS
{
    class Musica
    {
        public readonly string faixa;
        public readonly Artista artista;
        public readonly int duracao; //segundos
        private Genero[] generos;
        private bool disponivel;

        public string NomeArtista => $"{this.faixa} - {this.artista}";

        public string DurationFormatada => Globals.FormataDuracao(duracao);

        public Musica(string nome = "", Artista? artista = null, int duracao = 0, Genero[]? generos = null, bool disponivel = false)
        {
            this.faixa = nome;
            this.artista = artista ?? new Artista();
            this.duracao = duracao;
            this.generos = generos ?? new Genero[] { };
            this.disponivel = disponivel;
        }

        // object methods
        public void ExbirFichaTecnica()
        {
            Console.WriteLine($"Nome:       {this.faixa}");
            Console.WriteLine($"Artista:    {this.artista}");
            Console.WriteLine($"Duração:    {this.duracao} segundos");
            Console.WriteLine($"Gêneros:    {string.Join(", ", this.generos.Select(g => g.Nome))}");
            Console.WriteLine($"{(this.disponivel ? "Disponível no plano." : "Adquira no Plano+")}");
        }



        // overriden methods
        public override string ToString()
        {
            return this.faixa;
        }
    }
}
