using ProjetoFinalFaculdade.Models;
using ProjetoFinalFaculdade.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class ProfessorController : Controller
    {
        public List<Professor> Professores = new List<Professor>
        {
            new Professor {Id = 1, Nome="Rodrigo", Matricula = 1, DataNascimento = "22/06/1978", Email = "rodrigo@catolica", Telefone = 12341234},
            new Professor {Id = 2, Nome="Leonardo", Matricula = 2, DataNascimento = "05/09/1980", Email = "leonardo@catolica", Telefone = 15698745}
        };

        // GET: Professor
        public ActionResult Index()
        {
            var viewModel = new ProfessorIndexViewModel()
            {
                Professores = Professores
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Professores.Count < id)
            {
                return HttpNotFound();
            }
            var professor = Professores[id - 1];

            return View(professor);
        }
    }
}