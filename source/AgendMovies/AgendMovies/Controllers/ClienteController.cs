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
        public ActionResult VerPerfilCompras()
        {

            Cliente c = Session["Cliente"] as Cliente;
            if (c != null)
            {
                ViewBag.ClienteLogado = c;
                List<Compra> Compras = Banco.Compras.OrderBy(fs => fs.IdCliente).Where(co => co.IdCliente == c.Id).ToList();
                List<VerPerfilView> MinhasCompras = new List<VerPerfilView>();
                foreach (Compra C in Compras)
                {
                    VerPerfilView mc = new VerPerfilView();
                    mc.Sessao = Banco.Sessoes.Find(C.IdSessao);
                    mc.Filme = Banco.Filmes.Find(mc.Sessao.IdFilme);
                    mc.Pacote = Banco.Pacotes.Find(C.IdPacote);
                    MinhasCompras.Add(mc);
                }

                return View(MinhasCompras);
            }
            return RedirectToAction("Cadastrar", "Cliente");
        }
        [HttpPost]
        public ActionResult Cadastrar(Cliente f, HttpPostedFileBase arquivo)
        {

            if (arquivo != null)
            {
                f.TipoDaFoto = arquivo.ContentType;
                f.Foto = SetLogoTipo(arquivo);
            }

            Cliente cliente;
            try 
            {
                cliente=  Banco.Clientes.OrderBy(cli => cli.Id).Where(c => c.Email == f.Email).First(); 
            }
            catch
            {
                cliente = null;
            }
            if (cliente == null)
            {
                Banco.Clientes.Add(f);
            }
            Banco.SaveChanges();
            return RedirectToAction("Cadastrar", "Cliente");
        }
        [HttpPost]
        public ActionResult Login(Cliente f)
        {
            Cliente cliente = Banco.Clientes.FirstOrDefault(c => c.Email == f.Email && c.Senha == f.Senha);
            if(cliente != null)
            {
                Session["Cliente"] = cliente;
                return RedirectToAction("IndexCliente", "Home");
            }
            return RedirectToAction("Cadastrar", "Cliente");
        }
        [HttpPost]
        public ActionResult FazerCompra(Compra c, long? IdCliente, long? IdSessao)
        {
            try
            {
                c.IdSessao = (long)IdSessao;
                c.IdCliente = (long)IdCliente;
                Banco.Compras.Add(c);
                Banco.SaveChanges();
                Sessao s = Banco.Sessoes.Find(c.IdSessao);
                Filme f = Banco.Filmes.Find(s.IdFilme);
                return RedirectToAction("PedidoPacote", "Home", new { Id =f.FilmeId,});
            }
            catch
            {
                return RedirectToAction("IndexCliente", "Home");
            }
            
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