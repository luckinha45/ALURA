using System.Text.Json;
using Aula01NS;

namespace Aula04;

class _Exec
{
    public static void Executar()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                var response = client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                response.Wait();
                string content = response.Result;

                List<Models.Musica> musicas = JsonSerializer.Deserialize<List<Models.Musica>>(content)!;

                if (musicas.Count == 0)
                {
                    Console.WriteLine("Nenhuma música encontrada.");
                    return;
                }

                Filters.LinqMusica.SelectByTom(musicas, "C#");

                // Models.MusciasPreferidas musicasLucas = new("Lucas");
                // musicasLucas.AddMusciaFav(Filters.LinqMusica.SelectByNome(musicas, "Supermassive Black Hole"));
                // musicasLucas.AddMusciaFav(Filters.LinqMusica.SelectByNome(musicas, "You Rock My World"));
                // musicasLucas.AddMusciaFav(Filters.LinqMusica.SelectByNome(musicas, "Bad Romance"));
                // musicasLucas.AddMusciaFav(Filters.LinqMusica.SelectByNome(musicas, "Halo"));
                // musicasLucas.AddMusciaFav(Filters.LinqMusica.SelectByNome(musicas, "Take Me Out"));
                // musicasLucas.ExibMusicasFavs();

                // Models.MusciasPreferidas musicasLais = new("Lais");
                // musicasLais.AddMusciaFav(Filters.LinqMusica.SelectByNome(musicas, "Boy With Luv (feat. Halsey)"));
                // musicasLais.AddMusciaFav(Filters.LinqMusica.SelectByNome(musicas, "Single Ladies (Put a Ring on It)"));
                // musicasLais.AddMusciaFav(Filters.LinqMusica.SelectByNome(musicas, "Diamonds"));

                // musicasLucas.ExportToJson();
                // musicasLais.ExportToJson();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na requisição: {ex.Message}");
            }
        }        
    }
}