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

                musicas[0].ExibirDetalhes();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na requisição: {ex.Message}");
            }

        }        
    }
}