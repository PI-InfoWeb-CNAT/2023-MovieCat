using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult FuncionarioPage() //dashboard do funcionário
        {
            return View();
        }
    }
}