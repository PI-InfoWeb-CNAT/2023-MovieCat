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

        public int data { get; set; }

        public int telefone { get; set; }

        public string email { get; set; }
        
        public string senha { get; set; }

    }
}