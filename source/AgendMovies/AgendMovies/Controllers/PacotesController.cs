﻿using System;
using System.Collections.Generic;
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
        public ActionResult ListarPacotes()
        {
            return View();
        }
        public ActionResult Visualizar()
        {
            ViewBag.Pac = new Pacotes();
            ViewBag.Quant = T.Pacotes.OrderBy(pacotes => pacotes.nome).ToList().Count();
            return View(T.Pacotes.OrderBy(pacotes => pacotes.nome));
        }
        public ActionResult Cadastrar()
        {
            ViewBag.Quant = T.Pacotes.OrderBy(pacotes => pacotes.nome).ToList().Count();
            ViewBag.Pacotes = T.Pacotes.OrderBy(pacotes => pacotes.nome);
            
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Pacotes p)
        {
            T.Pacotes.Add(p);
            T.SaveChanges();
            return RedirectToAction("Visualizar");
        }

        public ActionResult Selecionar(long? id)
        {
            Session["Pacote"] = T.Pacotes.Find(id);
            return RedirectToAction("Visualizar");
        }
        public ActionResult Delete()
        {
            Pacotes x = (Pacotes)Session["Pacote"];
            Pacotes p = T.Pacotes.Find(x.PacotesId);
            T.Pacotes.Remove(p);
            T.SaveChanges();
            return RedirectToAction("Visualizar");
        }
    }
}