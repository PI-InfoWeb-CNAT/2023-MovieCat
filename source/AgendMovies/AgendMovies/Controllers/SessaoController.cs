using AgendMovies.Modelos;
using System;
using System.Collections.Generic;
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
            [HttpPost]
            public ActionResult Cadastrar(Sessao s, string quant, string dataf)
            {
                if (s.NomeFilme != "-")
                {
                //if (s.IdFilme == "seg")
                //{
                //    s.seg = true;
                //    s.ter = false;
                //    s.qua = false;
                //    s.qui = false;
                //    s.sex = false;
                //    s.sab = false;
                //    s.dom = false;
                //}
                //if (s.IdFilme == "ter")
                //{
                //    s.seg = false;
                //    s.ter = true;
                //    s.qua = false;
                //    s.qui = false;
                //    s.sex = false;
                //    s.sab = false;
                //    s.dom = false;
                //}
                //if (s.IdFilme == "qua")
                //{
                //    s.seg = false;
                //    s.ter = false;
                //    s.qua = true;
                //    s.qui = false;
                //    s.sex = false;
                //    s.sab = false;
                //    s.dom = false;
                //}
                //if (s.IdFilme == "qui")
                //{
                //    s.seg = false;
                //    s.ter = false;
                //    s.qua = false;
                //    s.qui = true;
                //    s.sex = false;
                //    s.sab = false;
                //    s.dom = false;
                //}
                //if (s.IdFilme == "sex")
                //{
                //    s.seg = false;
                //    s.ter = false;
                //    s.qua = false;
                //    s.qui = false;
                //    s.sex = true;
                //    s.sab = false;
                //    s.dom = false;
                //}
                //if (s.IdFilme == "sab")
                //{
                //    s.seg = false;
                //    s.ter = false;
                //    s.qua = false;
                //    s.qui = false;
                //    s.sex = false;
                //    s.sab = true;
                //    s.dom = false;
                //}
                //if (s.IdFilme == "dom")
                //{
                //    s.seg = false;
                //    s.ter = false;
                //    s.qua = false;
                //    s.qui = false;
                //    s.sex = false;
                //    s.sab = false;
                //    s.dom = true;
                //}
                string[] nomes = s.NomeFilme.Split('-');
                s.NomeFilme = nomes[0];
                s.IdFilme = nomes[1];
                
                string diaInicialStr = s.ToString();
                string diaFinalStr = dataf;
                string horaInicialStr = s.horaInicio;
                string duracaoMin = s.Duracao.ToString();
                string numSessoes = quant;
                DateTime diaInicial = DateTime.Parse(diaInicialStr);
                DateTime diaFinal = DateTime.Parse(diaFinalStr);
                DateTime dia = diaInicial;
                while (dia <= diaFinal)
                {
                    Console.WriteLine($"Sessões do Dia: {dia}");
                    TimeSpan horario = TimeSpan.Parse(horaInicialStr);
                    TimeSpan duracao = new TimeSpan(0, int.Parse(duracaoMin), 0);
                    for (int k = 0; k < int.Parse(numSessoes); k++)
                    {
                        DateTime data = dia + horario;
                        horario = horario + duracao;
                        // Colocar o inserir no banco aqui!
                        Sessao se = new Sessao();
                        se.IdFilme = s.IdFilme;
                        se.data = s.data;
                        se.Sala = s.Sala;
                        se.Idioma = Idioma.Orig;
                        se.horaInicio = horario.ToString();
                        // Banco.Sessoes.Add(s);
                        // Console.WriteLine(data.ToString());
                        Banco.Sessoes.Add(se);
                        Banco.SaveChanges();

                    }
                   
                    dia = dia.AddDays(1);
                }
                
                }

                return RedirectToAction("Home", "Administradores");

            }
        }
    }