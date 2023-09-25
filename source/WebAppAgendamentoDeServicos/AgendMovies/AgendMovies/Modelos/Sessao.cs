using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Sessao
    {
        public long SessaoId { get; set; }
        public string IdFilme { get; set; }
        public string NomeFilme { get; set; }
        public string data { get; set; }
        public string horaInicio { get; set; }
        public string horaFim { get; set; }
        public string Sala { get; set; }
        public bool nacional { get; set; }
        public bool dub { get; set; }
        public bool leg { get; set; }

        public bool seg { get; set; }
        public bool ter { get; set; }
        public bool qua { get; set; }
        public bool qui { get; set; }
        public bool sex { get; set; }
        public bool sab { get; set; }
        public bool dom { get; set; }


    }
}