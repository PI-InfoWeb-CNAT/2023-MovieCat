using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        Tabelas Banco = new Tabelas();
        public ActionResult Cadastrar()
        {
            return View(new Funcionario());
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
            Banco.Funcionarios.Add(f);
            Banco.SaveChanges();
            return RedirectToAction("Visualizar", "Funcionarios");

        }

        public ActionResult Listar()
        {
            List<Funcionario> Funcionarios = Banco.Funcionarios.ToList();
            //o método listar é feito com o list, entre o maior e o menor é o tipo da lista. depois chama a variavel que contem o banco, voce chama filmes e transforma em lista com o tolist

            return View(Funcionarios);
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