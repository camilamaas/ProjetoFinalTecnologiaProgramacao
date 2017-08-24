using ProjetoFinalFaculdade.Models;
using ProjetoFinalFaculdade.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class CursoController : Controller
    {

        public List<Curso> Cursos = new List<Curso>
        {
            new Curso {Id =1, Nome = "BSI", Ementa = "Esse curso visa aprender a programar!", Duracao = "4 anos", Mensalidade = 1037.85, Coordenador="Mauricio" },
            new Curso {Id =2, Nome = "Moda", Ementa = "Esse curso visa aprender sobre a moda!", Duracao = "4 anos", Mensalidade = 600.65, Coordenador="Carlos" }
        };

        // GET: Curso
        public ActionResult Index()
        {

            var viewModel = new CursoIndexViewModel()
            {
                Cursos = Cursos
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Cursos.Count < id)
            {
                return HttpNotFound();
            }
            var curso = Cursos[id - 1];

            return View(curso);
        }
    }
}