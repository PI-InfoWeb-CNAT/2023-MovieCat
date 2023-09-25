using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class AdministradoresController : Controller
    {
        // GET: Administradores
        Tabelas Banco = new Tabelas();
        public ActionResult Home()
        {
            return View(Banco.Filmes.OrderBy(f => f.FilmeId));
        }
    }
}