using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class PacotesController : Controller
    {

        // GET: Pacotes
        Tabelas T = new Tabelas();

        public ActionResult Visualizar()
        {
            
            

            Funcionario f = Session["Funcionario"] as Funcionario;
            if (f != null)
            {
                ViewBag.Funcionario = f;
                return View(T.Pacotes.OrderBy(pacotes => pacotes.PacotesId));
            }
            return RedirectToAction("Login");
        }
        public ActionResult Cadastrar()
        {
            


            Funcionario f = Session["Funcionario"] as Funcionario;
            if (f != null)
            {
                ViewBag.Funcionario = f;
                ViewBag.Quant = T.Pacotes.OrderBy(pacotes => pacotes.nome).ToList().Count();
                ViewBag.Pacotes = T.Pacotes.OrderBy(pacotes => pacotes.nome);

                return View();
            }
            return RedirectToAction("Login");
        }
        public ActionResult Editar(long? id)
        {
           


            Funcionario f = Session["Funcionario"] as Funcionario;
            if (f != null)
            {
                ViewBag.Funcionario = f;
                if (id == null)
                {
                    return HttpNotFound();
                }

                Pacotes pacote = T.Pacotes.Find(id);

                if (pacote == null)
                {
                    return HttpNotFound();
                }

                return View(pacote);
            }
            return RedirectToAction("Login");
        }
        public ActionResult VerPacote(long? id)
        {
          


            Funcionario f = Session["Funcionario"] as Funcionario;
            if (f != null)
            {
                ViewBag.Funcionario = f;
                if (id == null)
                {
                    return HttpNotFound();
                }

                Pacotes pacote = T.Pacotes.Find(id);

                if (pacote == null)
                {
                    return HttpNotFound();
                }

                return View(pacote);
            }
            return RedirectToAction("Login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Pacotes pacote)
        {
            if (ModelState.IsValid)
            {
                // Assuming that Pacotes has a property named PacotesId as the primary key
                T.Entry(pacote).State = EntityState.Modified; // EntityState.Modified is from System.Data.Entity
                T.SaveChanges();
                return RedirectToAction("Visualizar");
            }

            ViewBag.Quant = T.Pacotes.OrderBy(p => p.nome).ToList().Count();
            return View(pacote);
        }
        [HttpPost]
        public ActionResult Cadastrar(Pacotes p)
        {
            if (T.Pacotes.OrderBy(x => x.nome).Count() < 6)
            {
                T.Pacotes.Add(p);
                T.SaveChanges();
                return RedirectToAction("Visualizar");
            }
            return RedirectToAction("Visualizar");
        }
     
        public ActionResult Excluir(long id)
        {    
            Pacotes p = T.Pacotes.Find(id);
            T.Pacotes.Remove(p);
            T.SaveChanges();

            List<Compra> compras = T.Compras.OrderBy(c => c.CompraId).Where(comp => comp.IdPacote == id).ToList();
            foreach (Compra c in compras)
            {
                T.Compras.Remove(c);
                T.SaveChanges();
            }

            return RedirectToAction("Visualizar");
        }
        

    }
}