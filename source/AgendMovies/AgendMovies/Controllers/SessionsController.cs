using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class SessionsController : Controller
    {
        // GET: Sessions
        Tabelas Banco = new Tabelas();
        public ActionResult Cadastrar()
        {
            ICollection<Filme> fs = Banco.Filmes.OrderBy(f => f.FilmeId).ToList();
            List<SelectListItem> filmes = new List<SelectListItem>();
            foreach(Filme f in fs)
            {
                filmes.Add(new SelectListItem { Value = f.Nome+"-"+f.FilmeId, Text = f.Nome + "(" + f.FilmeId +")" });
            }
            
            ViewBag.Filmes = new SelectList(filmes, "Value", "Text");
            return View(new Sessao());
        }
        [HttpPost]
        public ActionResult Cadastrar(Sessao s)
        {
            if (s.NomeFilme != "-")
            {
                if (s.IdFilme == "seg")
                {
                    s.seg = true;
                    s.ter = false;
                    s.qua = false;
                    s.qui = false;
                    s.sex = false;
                    s.sab = false;
                    s.dom = false;
                }
                if (s.IdFilme == "ter")
                {
                    s.seg = false;
                    s.ter = true;
                    s.qua = false;
                    s.qui = false;
                    s.sex = false;
                    s.sab = false;
                    s.dom = false;
                }
                if (s.IdFilme == "qua")
                {
                    s.seg = false;
                    s.ter = false;
                    s.qua = true;
                    s.qui = false;
                    s.sex = false;
                    s.sab = false;
                    s.dom = false;
                }
                if (s.IdFilme == "qui")
                {
                    s.seg = false;
                    s.ter = false;
                    s.qua = false;
                    s.qui = true;
                    s.sex = false;
                    s.sab = false;
                    s.dom = false;
                }
                if (s.IdFilme == "sex")
                {
                    s.seg = false;
                    s.ter = false;
                    s.qua = false;
                    s.qui = false;
                    s.sex = true;
                    s.sab = false;
                    s.dom = false;
                }
                if (s.IdFilme == "sab")
                {
                    s.seg = false;
                    s.ter = false;
                    s.qua = false;
                    s.qui = false;
                    s.sex = false;
                    s.sab = true;
                    s.dom = false;
                }
                if (s.IdFilme == "dom")
                {
                    s.seg = false;
                    s.ter = false;
                    s.qua = false;
                    s.qui = false;
                    s.sex = false;
                    s.sab = false;
                    s.dom = true;
                }
                string[] nomes = s.NomeFilme.Split('-');
                s.NomeFilme= nomes[0];
                s.IdFilme = nomes[1];
                Banco.Sessoes.Add(s);
                Banco.SaveChanges();
            }
           
            return RedirectToAction("Home", "Administradores");

        }
    }
}