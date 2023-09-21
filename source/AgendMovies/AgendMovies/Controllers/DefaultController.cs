using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class DefaultController : Controller
    {
        Tabelas BDD = new Tabelas();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}