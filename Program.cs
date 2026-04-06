using RevisaoEstudos_API_LINQ_Serealizer.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        var resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        Console.WriteLine(musicas.Count);
       
    } catch (Exception ex) 
    {
        Console.WriteLine($"Erro ao realizar, a requisição da API {ex.Message}");
    }
}
