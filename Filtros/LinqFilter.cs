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


    //public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    //{
    //    var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).ToList().Distinct();

    //    foreach (var generoMusical in artistasPorGeneroMusical)
    //    {
    //        Console.WriteLine($"- {generoMusical}");
    //    }
    //}

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDeUmArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList().Distinct();

        foreach (var musicasDoArtista in musicasDeUmArtista)
        {
            Console.WriteLine($"- {musicasDoArtista.Nome}");
        }

    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();

        Console.WriteLine($"Musica do ano {ano}");
        foreach (var musicaAno in musicasPorAno)
        {
            Console.WriteLine($"- {musicaAno}");
        }

    }

    public static void FiltrarPorKeyMusical(List<Musica> musicas, int key)
    {
        var musicaKey = musicas.Where(musica => musica.KeyMusical == key).OrderBy(musica => musica.Nome).Select(musica => musica.KeyMusical).ToList();
        Console.WriteLine($"Musicas cujo a key é {key}");

        foreach (var musicao in musicaKey) 
        {
            switch (musicao) 
            {
                case 0:
                    Console.WriteLine("C");
                 break;

                case 1:
                 Console.WriteLine("C#");
                 break;
                case 2:
                    Console.WriteLine("D");
                break;
                case 3:
                    Console.WriteLine("D#");
                break;
                case 4:
                    Console.WriteLine("#");
                break;
                case 5:
                    Console.WriteLine("F");
                break;
                case 6:
                    Console.WriteLine("F#");
                break;
                case 7:
                    Console.WriteLine("G");
                break;
                case 8:
                    Console.WriteLine("G#");
                break;
                case 9:
                    Console.WriteLine("A");
                break;
                case 10:
                    Console.WriteLine("A#");
                break;
                case 11:
                    Console.WriteLine("B");
                break;
                default:
                    Console.WriteLine("Erro por gentileza, digite um numero valido entre 0 a 11");
                break;
            }
        }

    }

}
