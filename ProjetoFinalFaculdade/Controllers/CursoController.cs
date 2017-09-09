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

        private ApplicationDbContext _context;

        //public List<Curso> Cursos = new List<Curso>
        //{
        //    new Curso {Id =1, Nome = "BSI", Ementa = "Esse curso visa aprender a programar!", Duracao = "4 anos", Mensalidade = 1037.85, Coordenador="Mauricio" },
        //    new Curso {Id =2, Nome = "Moda", Ementa = "Esse curso visa aprender sobre a moda!", Duracao = "4 anos", Mensalidade = 600.65, Coordenador="Carlos" }
        //};

        public CursoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
                

        // GET: Curso
        public ActionResult Index()
        {

            var cursos = _context.Cursos.ToList();
            return View(cursos);
        }

        public ActionResult Details(int id)
        {
            var curso = _context.Cursos.SingleOrDefault(a => a.Id == id);
            if (curso == null)
            {
                return HttpNotFound();
            }

            return View(curso);
        }
    }
}