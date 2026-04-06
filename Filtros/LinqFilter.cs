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
        var todosOsGenerosMusicais = musicas.Select(musicas => musicas.Genero).ToList()!;
        Console.WriteLine($"Exibindo todos os generos filtrados");
        foreach (var generos in todosOsGenerosMusicais) 
        {
            Console.WriteLine($"- {generos}");
        }
    }
}
