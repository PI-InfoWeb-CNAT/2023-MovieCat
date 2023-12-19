using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Home()
        {
            Funcionario f = Session["Funcionario"] as Funcionario;
            if (f != null)
            {
                ViewBag.Funcionario = f;
                return View(f);
            }
            return RedirectToAction("Login");
           
        }
     
        public ActionResult Cadastrar()
        {
            return View(new Funcionario());
        }
        public ActionResult Listar()
        {

            return View(Banco.Funcionarios.OrderBy(f => f.FuncionarioId));
        }
        public ActionResult VerPacotesComprados()
        {


           

            Funcionario f = Session["Funcionario"] as Funcionario;
            if (f != null)
            {
                ViewBag.Funcionario = f;
                List<Compra> Compras = Banco.Compras.OrderByDescending(c => c.CompraId).ToList();
                List<VerPerfilView> ComprasView = new List<VerPerfilView>();
                foreach (Compra C in Compras)
                {
                    VerPerfilView mc = new VerPerfilView();
                    mc.Compra = C;
                    mc.Sessao = Banco.Sessoes.Find(C.IdSessao);
                    mc.Filme = Banco.Filmes.Find(mc.Sessao.IdFilme);
                    mc.Pacote = Banco.Pacotes.Find(C.IdPacote);
                    mc.Cliente = Banco.Clientes.Find(C.IdCliente);
                    ComprasView.Add(mc);
                }
                return View(ComprasView);
            }
            return RedirectToAction("Login");

        }
        public ActionResult ExlcluirPacoteComprado(long id)
        {

            Compra Compra = Banco.Compras.Find(id);
            Banco.Compras.Remove(Compra);
            Banco.SaveChanges();

            return RedirectToAction("VerPacotesComprados");

        }
        public ActionResult Login()
        {

            return View(new Funcionario());

        }
        [HttpPost]
        public ActionResult Login(Funcionario f)
        {

            Funcionario fun = Banco.Funcionarios.FirstOrDefault(c => c.email == f.email && c.senha == f.senha);
            if (fun != null)
            {
                Session["Funcionario"] = fun;
                return RedirectToAction("Home");
            }
            if(f.email.ToLower() == "adm@adm" && f.senha == "adm")
            {
                return RedirectToAction("Home", "Adm");
            }
            return RedirectToAction("Login");

        }
        public ActionResult VerPacoteComprado(long id)
        {

            
            Funcionario f = Session["Funcionario"] as Funcionario;
            if (f != null)
            {
                ViewBag.Funcionario = f;
                Compra Compra = Banco.Compras.Find(id);

                VerPerfilView mc = new VerPerfilView();
                mc.Compra = Compra;
                mc.Sessao = Banco.Sessoes.Find(Compra.IdSessao);
                mc.Filme = Banco.Filmes.Find(mc.Sessao.IdFilme);
                mc.Pacote = Banco.Pacotes.Find(Compra.IdPacote);
                mc.Cliente = Banco.Clientes.Find(Compra.IdCliente);

                return View(mc);
            }
            return RedirectToAction("Login");

        }
        public ActionResult Editar(long? id)
        {

            Funcionario f = Banco.Funcionarios.Find(id);
            if (f == null)
            {
                return RedirectToAction("Listar");
            }
            return View(f);
        }
        public ActionResult Excluir(long? id)
        {

            Funcionario f = Banco.Funcionarios.Find(id);
            if (f != null)
            {
                Banco.Funcionarios.Remove(f);
                Banco.SaveChanges();
            }
            return RedirectToAction("Listar");
        }
        public ActionResult Ver(long? id)
        {

            Funcionario f = Banco.Funcionarios.Find(id);
            if (f != null)
            {
                return View(f);
            }
            return RedirectToAction("Listar");
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
                Banco.Entry(f).State = EntityState.Modified;
                Banco.SaveChanges();
                return RedirectToAction("Listar");
            }
            return RedirectToAction("Listar");
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
            //return RedirectToAction("Visualizar", "Funcionarios");
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

            Funcionario F = Banco.Funcionarios.Find(id);
            if (F != null)
            {
                return File(F.Foto, F.TipoDaFoto);
            }
            return null;
        }

    }
}