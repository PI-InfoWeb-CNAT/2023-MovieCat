using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Cliente
    {
        
        public string Nome { get; set; }

     
        public string Cpf { get; set; }

        
        public string Email { get; set; }

        
        public string Senha { get; set; }
    }
}
