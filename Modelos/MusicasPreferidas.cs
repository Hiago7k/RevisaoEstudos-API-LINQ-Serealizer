using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoEstudos_API_LINQ_Serealizer.Modelos;

internal class MusicasPreferidas
{
    public MusicasPreferidas(string? nome, List<Musica> listaDeMusicasFavoritas)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }
}
