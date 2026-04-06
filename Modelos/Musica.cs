using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RevisaoEstudos_API_LINQ_Serealizer.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome {get;}
    [JsonPropertyName("artist")]
    public string? Artistia {get;}



    public void ExibitDetalhesDaMusica() 
    {
        Console.WriteLine("Realizando requsição...");
        Console.WriteLine($"- {Nome}");
        Console.WriteLine($"- {Artistia}");
    }
}
