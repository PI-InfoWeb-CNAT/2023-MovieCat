﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgendMovies.Modelos
{
    public class Tabelas: DbContext
    {
        public Tabelas() : base("Asp_Net_MVC_CS") { }
        public DbSet<Funcionario> Funcionarios { get; set; }


    }
}