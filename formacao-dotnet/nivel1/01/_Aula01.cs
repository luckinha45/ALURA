namespace Aula01NS
{
    class Aula01
    {
        public static void Executar()
        {
            // Criando alguns episódios
            Episodio ep1 = new Episodio(titulo: "Introdução ao Podcast", ordem: 1, duracao: 300);
            ep1.AdicionarConvidado("Alice");
            ep1.AdicionarConvidado("Bob");

            Episodio ep2 = new Episodio(titulo: "Entrevista com Especialista", ordem: 2, duracao: 1800);
            ep2.AdicionarConvidado("Dr. Carol");

            // Criando o podcast e adicionando episódios
            Podcast meuPodcast = new Podcast(nome: "Tech Talks", host: "John Doe");
            meuPodcast.AddEpisodio(ep2);
            meuPodcast.AddEpisodio(ep1);

            // Exibindo detalhes do podcast
            meuPodcast.ExibirDetalhes();
        }
    }
}