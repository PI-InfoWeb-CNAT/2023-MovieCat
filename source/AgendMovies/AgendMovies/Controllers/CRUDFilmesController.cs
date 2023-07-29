using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class CRUDFilmesController : Controller
    {
        Tabelas context = new Tabelas();
        // GET: CRUDFilmes
        public ActionResult Listar()
        {
            return View(context.Filmes.OrderByDescending(f => f.FilmeId));
        }
        public ActionResult Adicionar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Adicionar(Filme f, HttpPostedFileBase arquivo)
        {
            
            try
            {
                if (arquivo != null)
                {
                    f.TipoDaFoto = arquivo.ContentType;
                    f.ConteudoDaFoto = SetLogoTipo(arquivo);

                }
                context.Filmes.Add(f);
                context.SaveChanges();
                return RedirectToAction("Listar");
            }
            catch
            {
                return RedirectToAction("Listar");
            }
            
        }

        public ActionResult Selecionar(long? id)
        {
            Filme p = context.Filmes.Find(id);
            Session["Filme"] = p;
            TempData["Id"] = id;
            return RedirectToAction("Listar");
        }

        public ActionResult Delete()
        {

            Filme x = (Filme)Session["Filme"];

            if (x != null)
            {
                Filme p = context.Filmes.Find(x.FilmeId);
                context.Filmes.Remove(p);
                context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }

        private byte[] SetLogoTipo(HttpPostedFileBase arquivo)
        {
            var bytesFile = new byte[arquivo.ContentLength];
            arquivo.InputStream.Read(bytesFile, 0, arquivo.ContentLength);
            return bytesFile;
        }
        public FileContentResult GetLogoTipo(int? id)
        {

            Funcionario F = context.Funcionarios.Find(id);
            if (F != null)
            {
                return File(F.ConteudoDaFoto, F.TipoDaFoto);
            }
            return null;
        }
    }
}