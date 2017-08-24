using ProjetoFinalFaculdade.Models;
using ProjetoFinalFaculdade.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class DisciplinaController : Controller
    {
        public List<Disciplina> Disciplinas = new List<Disciplina>
        {
            new Disciplina {Id = 1, Nome="Programação 1", Ementa = "Desenvolver soluções.", CargaHoraria = 60},
            new Disciplina {Id = 2, Nome="Banco de dados 1", Ementa = "Entender SGBD.", CargaHoraria = 120 }
        };

        // GET: Disciplina
        public ActionResult Index()
        {
            var viewModel = new DisciplinaIndexViewModel()
            {
               Disciplinas = Disciplinas
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Disciplinas.Count < id)
            {
                return HttpNotFound();
            }
            var disciplina = Disciplinas[id - 1];

            return View(disciplina);
        }
    }
}