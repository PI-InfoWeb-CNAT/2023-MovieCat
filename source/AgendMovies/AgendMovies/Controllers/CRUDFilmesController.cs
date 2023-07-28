using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class CRUDFilmesController : Controller
    {
        Tabelas context = new Tabelas();
        // GET: CRUDFilmes
        public ActionResult Index()
        {
            return View();
        }
    }
}