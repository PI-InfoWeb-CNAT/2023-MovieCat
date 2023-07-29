using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Filme
    {
        public long FilmeId { get; set; }
        public string Nome { get; set; }
        public string Sinopse {get; set;}
        public string Indicativa { get; set; }
        public string Genero { get; set; }
        public byte[] ConteudoDaFoto { get; set; }
        public string TipoDaFoto { get; set; }
    }
}