using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendMovies.Modelos;

namespace AgendMovies.Controllers
{
    public class SessoesController : Controller
    {
        //Tabelas context = new Tabelas();
        //// GET: Sessoes
        //public ActionResult Listar()
        //{
           
        //    if (context.Sessoes.Count() <= 0)
        //    {
        //        List<string> Dias = new List<string> { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" }; 
        //        for (int i = 0; i < 7; i++)
        //        {
        //            context.Sessoes.Add(new Sessao() { diaSemana = Dias [i] });
        //        }
        //    }
        //    context.SaveChanges();
        //    return View(context.Sessoes.OrderBy(s => s.SessaoId));
        //}

        //public ActionResult Editar(long? id)
        //{
        //    ViewBag.Sessoes = context.Sessoes.OrderBy(p => p.SessaoId).ToList();
        //    return View(context.Sessoes.Find(id));
        //}

       
        //[HttpPost]
        //public ActionResult Editar(Sessao s)
        //{
        //    if (ModelState.IsValid)
        //    {
               
        //        context.Entry(s).State = EntityState.Modified;
        //        context.SaveChanges();
        //        return RedirectToAction("Listar");
        //    }
        //    return RedirectToAction("Listar");
        //}
        //public ActionResult Selecionar(long? id)
        //{
        //    Sessao p = context.Sessoes.Find(id);
        //    Session["Sessao"] = p;
        //    return RedirectToAction("Listar");
        //}
        //public ActionResult Limpar()
        //{

        //    Sessao x = (Sessao)Session["Sessao"];

        //    if (x != null)
        //    {
        //        Sessao p = new Sessao();
        //        p.SessaoId = x.SessaoId;
        //        p.diaSemana = x.diaSemana;
        //        context.Entry(p).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }

        //    return RedirectToAction("Listar");
        //}
    }
}