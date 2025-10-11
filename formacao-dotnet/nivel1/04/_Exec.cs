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
                string content = response.Result;
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na requisição: {ex.Message}");
            }

        }        
    }
}