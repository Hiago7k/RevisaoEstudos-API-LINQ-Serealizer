using RevisaoEstudos_API_LINQ_Serealizer.Filtros;
using RevisaoEstudos_API_LINQ_Serealizer.Filtrosl;
using RevisaoEstudos_API_LINQ_Serealizer.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        var resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //  LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.FiltrarPorArtista(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Post Malone");


    } catch (Exception ex) 
    {
        Console.WriteLine($"Erro ao realizar, a requisição da API {ex.Message}");
    }
}
