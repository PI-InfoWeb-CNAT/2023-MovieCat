using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Compra
    {
        public long CompraId{get;set;}
        public long IdSessao { get; set; }
        public long IdCliente { get; set; }
        public long IdPacote { get; set; }
    }
}