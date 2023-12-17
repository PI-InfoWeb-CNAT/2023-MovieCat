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
           
            
            Cliente c = Session["Cliente"] as Cliente;
            if (c != null)
            {
                ViewBag.ClienteLogado = c;
            }
            return View(BD.Filmes.OrderBy(f => f.FilmeId).ToList());
        }
        public ActionResult IndexCliente()
        {

            Cliente c = Session["Cliente"] as Cliente;
            if (c != null)
            {
                ViewBag.ClienteLogado = c;
                return View(BD.Filmes.OrderBy(fs => fs.FilmeId).ToList());
            }
            return RedirectToAction("Cadastrar", "Cliente");
        }
        public ActionResult PedidoPacote(string Id, string dia) 
        {
            Cliente c = Session["Cliente"] as Cliente;
            if (c != null)
            {
                ViewBag.ClienteLogado = c;
                List<SelectListItem> ps = new List<SelectListItem>();
                foreach (Pacotes p in BD.Pacotes.OrderBy(p => p.PacotesId))
                {
                    ps.Add(new SelectListItem { Value = p.PacotesId.ToString(), Text = p.nome + "(" + p.ingressos + "-"+p.valor+")" });
                }
                ViewBag.Pacotes = new SelectList(ps, "Value", "Text");
            }
            Filme x = BD.Filmes.Find(Id);
            if (x != null)
            {
                x.Sessoes = new List<Sessao>();                  
                
                if (dia == "seg")
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