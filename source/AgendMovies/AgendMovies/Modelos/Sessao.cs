using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Sessao
    {
        public long SessaoId { get; set; }
        public string diaSemana { get; set; }
        public string data { get; set; }
        public string manhaInicio { get; set; }
        public string manhaFim { get; set; }
        public string tardeInicio { get; set; }
        public string tardeFim { get; set; }
        public string noiteInicio { get; set; }
        public string noiteFim { get; set; }
        public bool dub { get; set; }
        public bool leg { get; set; }
    }
}