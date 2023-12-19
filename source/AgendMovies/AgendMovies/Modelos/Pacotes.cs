using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Pacotes
    {
        public long PacotesId { get; set; }
        public string nome { get; set; }

        public int ingressos { get; set; }

        public string valor { get; set; }
       
    }
}