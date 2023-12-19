using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class VerPerfilView
    {
        public Sessao Sessao { get; set; }
        public Filme Filme { get; set; }
        public Pacotes Pacote { get; set; }
        public Cliente Cliente { get; set; }
        public Compra Compra { get; set; }  
        
    }
}