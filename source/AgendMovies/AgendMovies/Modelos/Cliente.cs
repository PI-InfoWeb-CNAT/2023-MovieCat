using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Cliente
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Insira seu nome!")]
        public string Nome { get; set; }
        

        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, insira um endereço de email válido.")]
        public string Email { get; set; }

        [StringLength(30, ErrorMessage = "Sua senha deve ter no mínimo 5 caracteres!", MinimumLength = 5)]
        [Required(ErrorMessage = "Por favor, escreva a senha.")]
        public string Senha { get; set; }
        public byte[] Foto { get; set; }
        public string TipoDaFoto { get; set; }
    }
}
