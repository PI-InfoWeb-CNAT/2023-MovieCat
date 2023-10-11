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
                
                if (dia == "seg" || dia == null)
                {
                    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Monday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "ter")
                {
                    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "qua")
                {
                    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "qui")
                {
                    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Thursday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "sex")
                {
                    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Friday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "sab")
                {
                    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Saturday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else
                {
                    foreach (Sessao s in BD.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Sunday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                ViewBag.Dia = dia;
                return View(x);
            }
            return RedirectToAction("Index");
        }
    }
}