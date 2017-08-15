using ProjetoFinalFaculdade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {

            var curso = new Curso()
            {
                Nome = "BSI"
            };
            return View(curso);
        }
    }
}