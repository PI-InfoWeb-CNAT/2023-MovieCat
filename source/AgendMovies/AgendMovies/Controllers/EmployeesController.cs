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

        public ActionResult Home()
        {
            return View(Banco.Filmes.OrderBy(f => f.FilmeId));
        }

        public ActionResult Cadastrar()
        {
            return View(new Funcionario());
        }
        public ActionResult VerPacotesComprados()
        {


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
        public ActionResult VerPacoteComprado(long id)
        {

            Compra Compra = Banco.Compras.Find(id);
            
            VerPerfilView mc = new VerPerfilView();
            mc.Compra = Compra;
            mc.Sessao = Banco.Sessoes.Find(Compra.IdSessao);
            mc.Filme = Banco.Filmes.Find(mc.Sessao.IdFilme);
            mc.Pacote = Banco.Pacotes.Find(Compra.IdPacote);
            mc.Cliente = Banco.Clientes.Find(Compra.IdCliente);

            return View(mc);

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