using ProjetoFinalFaculdade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            var professor = new Professor()
            {
                Nome = "Rodrigo"
            };
            return View(professor);
        }
    }
}