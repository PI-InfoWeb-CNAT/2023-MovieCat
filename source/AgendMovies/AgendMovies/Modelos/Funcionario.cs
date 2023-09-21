using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Funcionario
    {
        [Required(ErrorMessage = "Você já conheceu alguém sem nome?")]
        public string nome { get; set; }

        public int FuncionarioId { get; set; }

        [StringLength(8, ErrorMessage = "Insira uma data de nascimento completa e válida, por favor.", MinimumLength = 8)]
        [Required(ErrorMessage = "Você já conheceu alguém que não nasceu?")]
        public string data { get; set; }

        [StringLength(15, ErrorMessage = "Insira um número de telefone válido, por favor.", MinimumLength = 15)]
        [Required(ErrorMessage = "Por favor, insira um número de telefone.")]
        public string telefone { get; set; }

        [Required(ErrorMessage = "Por favor, insira um endereço de email válido.")]
        public string email { get; set; }

        [StringLength(30, ErrorMessage = "Sua senha deve ter no mínimo 5 caracteres!", MinimumLength = 5)]
        [Required(ErrorMessage = "Por favor, escreva a sinopse do filme.")]
        public string senha { get; set; }

        [StringLength(11, ErrorMessage = "Insira o CPF completo, incluindo os dois últimos dígitos verificadores!", MinimumLength = 1)]
        [Required(ErrorMessage = "Por favor, insira o CPF.")]
        public string cpf { get; set; }
        public byte[] ConteudoDaFoto { get; set; }
        public string TipoDaFoto { get; set; }
    }
}