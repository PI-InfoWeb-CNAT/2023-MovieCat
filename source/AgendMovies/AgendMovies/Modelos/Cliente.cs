using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Cliente
    {
        [Required(ErrorMessage = "Você já conheceu alguém sem nome?")]
        public string Nome { get; set; }

        [StringLength(11, ErrorMessage = "Insira o CPF completo, incluindo os dois últimos dígitos verificadores!", MinimumLength = 1)]
        [Required(ErrorMessage = "Por favor, insira o CPF.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, insira um endereço de email válido.")]
        public string Email { get; set; }

        [StringLength(30, ErrorMessage = "Sua senha deve ter no mínimo 5 caracteres!", MinimumLength = 5)]
        [Required(ErrorMessage = "Por favor, escreva a sinopse do filme.")]
        public string Senha { get; set; }
    }
}
