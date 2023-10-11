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
                    filmes.Add(new SelectListItem { Value = f.Nome + "-" + f.FilmeId, Text = f.Nome + "(" + f.FilmeId + ")" });
                }

                ViewBag.Filmes = new SelectList(filmes, "Value", "Text");
                return View(new Sessao());
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
                 return RedirectToAction("Cadastrar");
            }
            [HttpPost]
            public ActionResult Editar(Sessao s)
             {

                Banco.Entry(s).State = EntityState.Modified;
                Banco.SaveChanges();
                return RedirectToAction("Cadastrar");
             }
            [HttpPost]
            public ActionResult Cadastrar(Sessao s, string quant, string dataf, string datai)
            {
                if (s.NomeFilme != "-")
                {
               
                string[] nomes = s.NomeFilme.Split('-');
                s.NomeFilme = nomes[0];
                s.IdFilme = nomes[1];
                Filme f = Banco.Filmes.Find(s.IdFilme);

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
                        se.NomeFilme = f.Nome;

                        Banco.Sessoes.Add(se);
                        Banco.SaveChanges();
                        horario = horario + duracao;


                    }
                   
                    dia = dia.AddDays(1);
                }
                
                }
            
            return RedirectToAction("Home", "Administradores");

            }
        }
    }