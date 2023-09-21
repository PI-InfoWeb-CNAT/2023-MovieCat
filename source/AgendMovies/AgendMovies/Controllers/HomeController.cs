using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class HomeController : Controller
    {
        Tabelas BD = new Tabelas();
        // GET: Home
        public ActionResult Index()
        {
           
            return View(BD.Filmes.OrderBy(c => c.FilmeId).ToList());
        }
    }
}