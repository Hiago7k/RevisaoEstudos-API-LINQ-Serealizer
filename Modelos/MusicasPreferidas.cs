using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoEstudos_API_LINQ_Serealizer.Modelos;

internal class MusicasPreferidas
{
    public MusicasPreferidas(string? nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public void AdicionarMusicaNaLista(Musica musica) 
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasPreferidas() 
    {
        Console.WriteLine($"Musicas Favoritas de {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas) 
        {
            Console.WriteLine($" {musica.Nome} | {musica.Artista}");
        }
        Console.WriteLine();
    }
}
