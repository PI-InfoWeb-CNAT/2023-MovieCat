using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class CadastroDePacotesController : Controller
    {
        // GET: CadastroDePacotes
        public ActionResult CadastrarPacotes()
        {
            return View();
        }
    }
}