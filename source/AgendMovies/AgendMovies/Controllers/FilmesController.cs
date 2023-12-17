using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class FilmesController : Controller
    {
        // GET: Filmes
        
            Tabelas Banco = new Tabelas();
            // GET: Movies
            public ActionResult Cadastrar()
            {
                return View(new Filme());
            }
            [HttpPost]
            public ActionResult Cadastrar(Filme filme, HttpPostedFileBase arquivo)
            {
                try
                {
                    if (arquivo != null)
                    {
                        filme.TipoDaFoto = arquivo.ContentType;
                        filme.ConteudoDaFoto = SetLogoTipo(arquivo);

                    }
                    Banco.Filmes.Add(filme);
                    Banco.SaveChanges();
                    return RedirectToAction("Home", "Adm");
                }
                catch
                {
                    return RedirectToAction("Home", "Adm");
                }
            }
        public ActionResult Listar()
            {

            List<Filme> Filmes = Banco.Filmes.ToList();
            //o método listar é feito com o list, entre o maior e o menor é o tipo da lista. depois chama a variavel que contem o banco, voce chama filmes e transforma em lista com o tolist

                return View(Filmes);
            }

        public ActionResult Editar(string id)
        {

            Filme filme = Banco.Filmes.Find(id);
            if (filme == null)
            {
                return RedirectToAction("Listar");
            }
            return View(filme);
        }

        [HttpPost]
        public ActionResult Editar(Filme filme, HttpPostedFileBase arquivo)
        {
            try { 
                if (arquivo != null)
                {
                    filme.TipoDaFoto = arquivo.ContentType;
                    filme.ConteudoDaFoto = SetLogoTipo(arquivo);

                }
                if (filme.Categoria == "Em Breve")
                {
                    List<Sessao> sessoes = Banco.Sessoes.OrderBy(s => s.IdFilme).Where(se => se.IdFilme == filme.FilmeId).ToList();
                    foreach (Sessao s in sessoes)
                    {
                        List<Compra> compras = Banco.Compras.OrderBy(c => c.IdSessao).Where(co => co.IdSessao == s.SessaoId).ToList();
                        foreach (Compra c in compras)
                        {
                            Banco.Compras.Remove(c);
                            Banco.SaveChanges();
                        }
                        Banco.Sessoes.Remove(s);
                        Banco.SaveChanges();
                    }
                }
                Banco.Entry(filme).State = EntityState.Modified;
                Banco.SaveChanges();
                return RedirectToAction("Listar", "Filmes");
            }
            catch
            {
                return RedirectToAction("Listar", "Filmes");
            }
            
        }

        public ActionResult Excluir(string id)
        {
        
           Filme filme = Banco.Filmes.Find(id);

           if (filme != null)
            {
               
                List<Sessao> sessoes = Banco.Sessoes.OrderBy(s => s.IdFilme).Where(se => se.IdFilme == id).ToList();
                foreach(Sessao s in sessoes)
                {
                    List<Compra> compras = Banco.Compras.OrderBy(c => c.IdSessao).Where(co => co.IdSessao == s.SessaoId).ToList();
                    foreach(Compra c in compras)
                    {
                        Banco.Compras.Remove(c);
                        Banco.SaveChanges();
                    }
                    Banco.Sessoes.Remove(s);
                    Banco.SaveChanges();
                }
                Banco.Filmes.Remove(filme);
                Banco.SaveChanges();
               // Página de erro 404
            }
            return RedirectToAction("Listar");


            // Redireciona para a página de listagem de filmes após a exclusão
        }

        private byte[] SetLogoTipo(HttpPostedFileBase arquivo)
        {
            var bytesFile = new byte[arquivo.ContentLength];
            arquivo.InputStream.Read(bytesFile, 0, arquivo.ContentLength);
            return bytesFile;
        }
        public FileContentResult GetLogoTipo(string id)
        {

            Filme F = Banco.Filmes.Find(id);
            if (F != null)
            {
                return File(F.ConteudoDaFoto, F.TipoDaFoto);
            }
            return null;
        }

        public ActionResult VerFilmes(string id, string dia)
        {
            Filme x = Banco.Filmes.Find(id);
            if (x != null)
            {
                x.Sessoes = new List<Sessao>();

                if (dia == "seg" || dia == null)
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Monday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "ter")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "qua")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "qui")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Thursday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "sex")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Friday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "sab")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Saturday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
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
 