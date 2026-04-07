using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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


    public void GerarArquivoJson() 
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });

        string nomeDoArquvio = $"musicas-favoritas-{Nome}.Json";
        File.WriteAllText(nomeDoArquvio, json);
        Console.WriteLine($"O Arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquvio)} ");
    }

    public void GearArquivoTxt() 
    {
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo)) 
        {
            arquivo.WriteLine($"Musicas favoritas do {Nome}\n");
            foreach (var musica in ListaDeMusicasFavoritas) 
            {
                arquivo.WriteLine($"- {musica.Nome}");
            }
        }
        Console.WriteLine("txt gerado com sucesso!");
    }
}
