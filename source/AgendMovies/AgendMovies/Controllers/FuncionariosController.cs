using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class FuncionariosController : Controller
    {
        Tabelas context = new Tabelas();

        // GET: Funcionarios
        public ActionResult Visualizar()
        {
            return View(context.Funcionarios.OrderBy(f => f.nome));
        }
        public ActionResult Cadastrar()
        {
            return View();
        }
        
        public ActionResult Detalhes(int? id)
        {
           
            Funcionario thiago = context.Funcionarios.Find(id);
            if (thiago == null)
            {
                return RedirectToAction("Visualizar");
            }
            return View(thiago);
        }
        public ActionResult Editar(int? id)
        {

            Funcionario f = context.Funcionarios.Find(id);
            if (f == null)
            {
                return RedirectToAction("Visualizar");
            }
            return View(f);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Funcionario f, HttpPostedFileBase arquivo)
        {
            
                if (arquivo != null)
                {
                    f.TipoDaFoto = arquivo.ContentType;
                    f.Foto = SetLogoTipo(arquivo);
                }
                context.Funcionarios.Add(f);
                context.SaveChanges();
                return RedirectToAction("Visualizar");
            
        }
        [HttpPost]
        public ActionResult Editar(Funcionario f, HttpPostedFileBase arquivo)
        {
            if (ModelState.IsValid)
            {
                if (arquivo != null)
                {
                    f.TipoDaFoto = arquivo.ContentType;
                    f.Foto = SetLogoTipo(arquivo);

                }
                context.Entry(f).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Visualizar");
            }
            return RedirectToAction("Visualizar");
        }


        public ActionResult Excluir(int? id)
        {
            Funcionario thiago = context.Funcionarios.Find(id);
            if (thiago == null)
            {
                return RedirectToAction("Visualizar");
            }
            context.Funcionarios.Remove(thiago);
            context.SaveChanges();
            return RedirectToAction("Visualizar");
        }
        private byte[] SetLogoTipo(HttpPostedFileBase arquivo)
        {
            var bytesFile = new byte[arquivo.ContentLength];
            arquivo.InputStream.Read(bytesFile, 0, arquivo.ContentLength);
            return bytesFile;
        }
        public FileContentResult GetLogoTipo(int? id)
        {

            Funcionario  F = context.Funcionarios.Find(id);
            if (F != null)
            {
                return File(F.Foto, F.TipoDaFoto);
            }
            return null;
        }
    }
}