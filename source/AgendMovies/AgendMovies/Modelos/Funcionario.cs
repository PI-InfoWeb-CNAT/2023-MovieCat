using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Funcionario
    {

        public string nome { get; set; }

        public int FuncionarioId { get; set; }

        public string data { get; set; }

        public int telefone { get; set; }

        public string email { get; set; }
        
        public string senha { get; set; }
        public string cpf { get; set; }
        public byte[] ConteudoDaFoto { get; set; }
        public string TipoDaFoto { get; set; }
    }
}