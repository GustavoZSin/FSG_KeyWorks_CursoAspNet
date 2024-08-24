using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Music
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Artista { get; set; }
        public int SegundosDuracao { get; set; }

        public Music(int id, string nome, string genero, string artista, int segundosDuracao)
        {
            Id = id;
            Nome = nome;
            Genero = genero;
            Artista = artista;
            SegundosDuracao = segundosDuracao;
        }
    }
}
