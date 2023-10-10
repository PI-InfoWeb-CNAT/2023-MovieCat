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
        public ActionResult PedidoPacote(string Id, string dia) 
        {
            
            Filme x = BD.Filmes.Find(Id);
            if (x != null)
            {
                x.Sessoes = new List<Sessao>();

                //if (dia == "seg" || dia == null)
                //{
                //    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                //    {
                //        if (s.IdFilme == x.FilmeId && s.seg == true)
                //        {
                //            x.Sessoes.Add(s);
                //        }
                //    }
                //}
                //else if (dia == "ter" )
                //{
                //    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                //    {
                //        if (s.IdFilme == x.FilmeId && s.ter == true)
                //        {
                //            x.Sessoes.Add(s);
                //        }
                //    }
                //}
                //else if(dia == "qua")
                //{
                //    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                //    {
                //        if (s.IdFilme == x.FilmeId && s.qua == true)
                //        {
                //            x.Sessoes.Add(s);
                //        }
                //    }
                //}
                //else if (dia == "qui")
                //{
                //    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                //    {
                //        if (s.IdFilme == x.FilmeId && s.qui == true && s != null)
                //        {
                //            x.Sessoes.Add(s);
                //        }
                //    }
                //}
                //else if (dia == "sex")
                //{
                //    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                //    {
                //        if (s.IdFilme == x.FilmeId && s.sex == true)
                //        {
                //            x.Sessoes.Add(s);
                //        }
                //    }
                //}
                //else if (dia == "sab")
                //{
                //    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                //    {
                //        if (s.IdFilme == x.FilmeId && s.sab == true)
                //        {
                //            x.Sessoes.Add(s);
                //        }
                //    }
                //}
                //else
                //{
                //    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                //    {
                //        if (s.IdFilme == x.FilmeId && s.dom == true)
                //        {
                //            x.Sessoes.Add(s);
                //        }
                //    }
                //}
                ViewBag.Dia = dia;
                return View(x);
            }
            return RedirectToAction("Index");
        }
    }
}