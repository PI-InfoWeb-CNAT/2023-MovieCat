using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class MoviesController : Controller
    {
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
                return RedirectToAction("Home", "Administradores");
            }
            catch
            {
                return RedirectToAction("Home", "Administradores");
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