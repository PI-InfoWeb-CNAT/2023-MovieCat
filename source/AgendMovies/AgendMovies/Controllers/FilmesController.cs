using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
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