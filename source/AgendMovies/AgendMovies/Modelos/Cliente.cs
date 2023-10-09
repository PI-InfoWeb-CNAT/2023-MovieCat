using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Cliente
    {
        [Required(ErrorMessage = "Insira seu nome!")]
        public string Nome { get; set; }
        

        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, insira um endereço de email válido.")]
        public string Email { get; set; }

        
        public string Senha { get; set; }
    }
}
