using RevisaoEstudos_API_LINQ_Serealizer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoEstudos_API_LINQ_Serealizer.Filtros;

internal class LinqOrder
{
    public static void FiltrarPorArtista(List<Musica> musicas) 
    {
        var todosOsArtista = musicas.OrderBy(musicas => musicas.Artistia).Select(musicas => musicas.Artistia).Distinct().ToList()!;
        Console.WriteLine("Exibindo Artistia Ordenados");

        foreach (var artistas in todosOsArtista) 
        {
            Console.WriteLine($"- {artistas}");
        }

    }
}
