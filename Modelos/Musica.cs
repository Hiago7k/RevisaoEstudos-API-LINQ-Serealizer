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
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artistia { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
   

    public void ExibitDetalhesDaMusica() 
    {
        Console.WriteLine("Realizando requsição...");
        Console.WriteLine($"- Musica: {Nome}");
        Console.WriteLine($"- Artista: {Artistia}");
        Console.WriteLine($"- Genero: {Genero}");
    }
}
