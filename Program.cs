using RevisaoEstudos_API_LINQ_Serealizer.Filtrosl;
using RevisaoEstudos_API_LINQ_Serealizer.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        var resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1998].ExibitDetalhesDaMusica();
        LinqFilter.FiltrarTodosOsGeneros(musicas);

    } catch (Exception ex) 
    {
        Console.WriteLine($"Erro ao realizar, a requisição da API {ex.Message}");
    }
}
