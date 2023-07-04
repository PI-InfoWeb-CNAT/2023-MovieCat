using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class FuncionariosController : Controller
    {
        Tabelas context = new Tabelas();

        // GET: Funcionarios
        public ActionResult Visualizar()
        {
            return View(context.Funcionarios.OrderBy(f => f.nome));
        }
    }
}