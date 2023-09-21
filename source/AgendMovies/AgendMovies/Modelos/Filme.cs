using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Filme
    {
        
        public long FilmeId { get; set; }
        [Required(ErrorMessage = "Por favor, insira o nome do filme.")]
        public string Nome { get; set; }

        [StringLength(300, ErrorMessage = "Sua sinopse ultrapassou o limite de caracteres ou não alcançou o limite mínimo!", MinimumLength = 30)]
        [Required(ErrorMessage = "Por favor, escreva a sinopse do filme.")]
        public string Sinopse {get; set;}

        public string Indicativa { get; set; }
        [Required(ErrorMessage = "Por favor, insira um gênero para o filme.")]
        public string Genero { get; set; }
        public byte[] ConteudoDaFoto { get; set; }
        public string TipoDaFoto { get; set; }

        public string Categoria { get; set; }

        public int Duracao { get; set; }

    }
}