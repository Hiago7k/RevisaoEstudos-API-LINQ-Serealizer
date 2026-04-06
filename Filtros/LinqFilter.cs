using RevisaoEstudos_API_LINQ_Serealizer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoEstudos_API_LINQ_Serealizer.Filtrosl;

internal class LinqFilter
{
    public static void FiltrarTodosOsGeneros(List<Musica> musicas) 
    {
        var todosOsGenerosMusicais = musicas.Select(musicas => musicas.Genero).Distinct().ToList()!;
        Console.WriteLine($"Exibindo todos os generos filtrados");
        foreach (var generos in todosOsGenerosMusicais) 
        {
            Console.WriteLine($"- {generos}");
        }
    }


    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).ToList().Distinct();

        foreach (var generoMusical in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {generoMusical}");
        }
    }


    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista) 
    {
        var musicasDeUmArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList().Distinct();

        foreach (var musicasDoArtista in musicasDeUmArtista) 
        {
            Console.WriteLine($"- {musicasDoArtista.Nome}");
        }

    }

}
