using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class ClienteController : Controller
    {
        Tabelas Banco = new Tabelas();
        // GET: Cliente
        public ActionResult Cadastrar()
        {
            return View(new Cliente());
        }
        [HttpPost]
        
        public ActionResult Cadastrar(Cliente f, HttpPostedFileBase arquivo)
        {

            if (arquivo != null)
            {
                f.TipoDaFoto = arquivo.ContentType;
                f.Foto = SetLogoTipo(arquivo);
            }
            Banco.Clientes.Add(f);
            Banco.SaveChanges();
            return RedirectToAction("Cadastrar", "Cliente");
        }
        private byte[] SetLogoTipo(HttpPostedFileBase arquivo)
        {
            var bytesFile = new byte[arquivo.ContentLength];
            arquivo.InputStream.Read(bytesFile, 0, arquivo.ContentLength);
            return bytesFile;
        }
        public FileContentResult GetLogoTipo(int? id)
        {

            Funcionario F = Banco.Funcionarios.Find(id);
            if (F != null)
            {
                return File(F.Foto, F.TipoDaFoto);
            }
            return null;
        }
    }
}