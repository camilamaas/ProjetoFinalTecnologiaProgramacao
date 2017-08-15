using ProjetoFinalFaculdade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class DisciplinaController : Controller
    {
        // GET: Disciplina
        public ActionResult Index()
        {
            var disciplna = new Disciplina()
            {
                Nome = "Tecnologia de Programação II"
            };
            return View(disciplna);
        }
    }
}