﻿using ProjetoFinalFaculdade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Camila"
            };
            return View(aluno);
        }
    }
}