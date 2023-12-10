using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class SessaoController : Controller
    {
        // GET: Sessao
      
        // GET: Sessions
        Tabelas Banco = new Tabelas();
        public ActionResult Cadastrar()
        {
            ICollection<Filme> fs = Banco.Filmes.OrderBy(f => f.FilmeId).ToList();
            List<SelectListItem> filmes = new List<SelectListItem>();
            foreach (Filme f in fs)
            {
                if (f.Categoria != "Em Breve")
                {
                    filmes.Add(new SelectListItem { Value = f.FilmeId, Text = f.Nome + "(" + f.FilmeId + ")" });
                }
               
            }

            ViewBag.Filmes = new SelectList(filmes, "Value", "Text");
            return View(new Sessao());
        }

        public ActionResult Listar()
        {
            List<string> Ids = new List<string>();
            foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.IdFilme).ToList())
            {
                if (Ids.IndexOf(s.IdFilme) == -1)
                {
                    Ids.Add(s.IdFilme);
                }
            }
            List<Filme> fs =new List<Filme>();
            foreach (Filme f in Banco.Filmes.OrderBy(se => se.FilmeId).ToList())
            {
                if (Ids.IndexOf(f.FilmeId) != -1)
                {
                    fs.Add(f);
                }
            }
            return View(fs);

        }

        public ActionResult VerSessoes(string Id, string dia)
        {

            Filme x = Banco.Filmes.Find(Id);
            if (x != null)
            {
                x.Sessoes = new List<Sessao>();

                if (dia == "seg" || dia == null)
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Monday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "ter")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "qua")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "qui")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Thursday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "sex")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Friday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else if (dia == "sab")
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Saturday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                else
                {
                    foreach (Sessao s in Banco.Sessoes.OrderBy(se => se.SessaoId).ToList())
                    {
                        if (s.IdFilme == x.FilmeId && s.data.DayOfWeek == DayOfWeek.Sunday)
                        {
                            x.Sessoes.Add(s);
                        }
                    }
                }
                ViewBag.Dia = dia;
                return View(x);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Editar(long id)
        {
                
            Sessao s = Banco.Sessoes.Find(id);
            if (s != null)
            {
                Filme f = Banco.Filmes.Find(s.IdFilme);
            s.NomeFilme = f.Nome;
                return View(s);
            }
                return RedirectToAction("VerSessoes", new { id = s.IdFilme, dia = "seg" });
        }
        [HttpPost]
        public ActionResult Editar(Sessao s)
            {

            Banco.Entry(s).State = EntityState.Modified;
            Banco.SaveChanges();
            return RedirectToAction("VerSessoes", new { id = s.IdFilme, dia = "seg" });
            }
        [HttpPost]
        public ActionResult Cadastrar(Sessao s, string quant, string dataf, string datai)
        {
            if (s.NomeFilme != "" || s.NomeFilme != null)
            {
               
            
            Filme f = Banco.Filmes.Find(s.NomeFilme);
            s.NomeFilme = f.Nome;
            s.IdFilme = f.FilmeId;

                string[] datasInicial = datai.Split('-');
            string[] datasFinal =dataf.Split('-');

            string diaInicialStr = datasInicial[2]+"/" + datasInicial[1]+ "/"+datasInicial[0];
            string diaFinalStr = datasFinal[2] + "/" + datasFinal[1] + "/" + datasFinal[0];
            string horaInicialStr = s.horaInicio;
            string duracaoMin = s.Duracao.ToString();
            string numSessoes = quant;
            DateTime diaInicial = DateTime.Parse(diaInicialStr);
            DateTime diaFinal = DateTime.Parse(diaFinalStr);
            DateTime dia = diaInicial;
            while (dia <= diaFinal)
            {
                TimeSpan horario = TimeSpan.Parse(horaInicialStr);
                TimeSpan duracao = new TimeSpan(0, int.Parse(duracaoMin), 0);
                for (int k = 0; k < int.Parse(numSessoes); k++)
                {
                    DateTime data = dia + horario;
                        
                    // Colocar o inserir no banco aqui!
                    Sessao se = new Sessao();
                    se.IdFilme = s.IdFilme;
                    se.data = data;
                    se.Sala = s.Sala;
                    se.horaInicio = horario.ToString();
                    se.Duracao = duracaoMin;
                    se.NomeFilme = s.NomeFilme;

                    Banco.Sessoes.Add(se);
                    Banco.SaveChanges();
                    horario = horario + duracao;


                }
                   
                dia = dia.AddDays(1);
            }
                
            }
            
        return RedirectToAction("Home", "Adm");

        }

        public ActionResult Excluir(long? id)
        {

            Sessao s = Banco.Sessoes.Find(id);

            if (s != null)
            {
                Banco.Sessoes.Remove(s);
                Banco.SaveChanges();
                // Página de erro 404
            }
            return RedirectToAction("VerSessoes", new { id = s.IdFilme, dia = "seg" });


            // Redireciona para a página de listagem de filmes após a exclusão
        }


    }
}