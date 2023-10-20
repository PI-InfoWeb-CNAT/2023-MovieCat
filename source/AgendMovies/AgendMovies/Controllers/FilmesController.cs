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
                return RedirectToAction("Editar");
            }
            return View(filme);
        }

        public void Excluir (string filmeId)
        {
            var filmeParaExcluir = Banco.Filmes.FirstOrDefault(f => f.FilmeId == filmeId);

            if (filmeParaExcluir != null)
            {
                Banco.Filmes.Remove(filmeParaExcluir);
                Banco.SaveChanges();
            }
        }

        [HttpPost]
        public ActionResult Editar(Filme filme, HttpPostedFileBase arquivo)
        {
            if (ModelState.IsValid)
            {
                if (arquivo != null)
                {
                    filme.TipoDaFoto = arquivo.ContentType;
                    filme.ConteudoDaFoto = SetLogoTipo(arquivo);

                }
                Banco.Entry(filme).State = EntityState.Modified;
                Banco.SaveChanges();
                return RedirectToAction("Visualizar");
            }
            return RedirectToAction("Visualizar");
        }

        //public ActionResult Excluir(string filmeid)
        //{
        //    var filme = Banco.Filmes.Find(id);

        //    if (filme == null)
        //    {
        //        return HttpNotFound(); // Página de erro 404
        //    }

        //    Banco.Filmes.Remove(filme);
        //    Banco.SaveChanges();

        //    return RedirectToAction("Listar"); // Redireciona para a página de listagem de filmes após a exclusão
        //}

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
            
            
        }
    } 