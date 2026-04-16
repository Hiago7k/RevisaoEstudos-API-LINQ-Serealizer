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
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Post Malone");
      //   LinqFilter.FiltrarMusicasPorAno(musicas, 2014);

        LinqFilter.FiltrarPorKeyMusical(musicas, 3);

        //MusicasPreferidas hiago = new MusicasPreferidas("Hiago List");
        //hiago.AdicionarMusicaNaLista(musicas[23]);
        //hiago.AdicionarMusicaNaLista(musicas[10]);
        //hiago.AdicionarMusicaNaLista(musicas[123]);
        //hiago.AdicionarMusicaNaLista(musicas[99]);
        //hiago.AdicionarMusicaNaLista(musicas[1]);
        //hiago.ExibirMusicasPreferidas();
        //hiago.GearArquivoTxt();

        //MusicasPreferidas nath = new("Nath List");
        //nath.AdicionarMusicaNaLista(musicas[1]);
        //nath.AdicionarMusicaNaLista(musicas[11]);
        //nath.AdicionarMusicaNaLista(musicas[12]);
        //nath.AdicionarMusicaNaLista(musicas[222]);
        //nath.AdicionarMusicaNaLista(musicas[22]);
        //nath.ExibirMusicasPreferidas();
        //nath.GerarArquivoJson();
        Console.WriteLine("Strak");
        Console.WriteLine("Strak");
        Console.WriteLine("Strak");
        Console.WriteLine("Strak");
        Console.WriteLine("Strak");
        Console.WriteLine("Strak");
        Console.WriteLine("Strak");
        Console.WriteLine("Strak");
        Console.WriteLine("Strak");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao realizar, a requisição da API {ex.Message}");
    }
}


