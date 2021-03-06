﻿using ProjetoFinalFaculdade.Models;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers {
    public class ProfessorController : Controller {

        private ApplicationDbContext _context;


        public ProfessorController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
        }

        // GET: Professor
        public ActionResult Index() {
            var professores = _context.Professores.ToList();
            if (User.IsInRole(RoleName.CanManageData))
                return View(professores);

            return View("ReadOnlyIndex", professores);
        }

        public ActionResult Details(int id) {
            var professor = _context.Professores.SingleOrDefault(p => p.Id == id);
            if (professor == null) {
                return HttpNotFound();
            }

            return View(professor);
        }

        [Authorize(Roles = RoleName.CanManageData)]
        public ActionResult New() {
            var professor = new Professor();

            return View("ProfessorForm", professor);
        }

        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageData)]
        public ActionResult Save(Professor professor) // recebemos um professor
        {
            if (!ModelState.IsValid) {
                return View("ProfessorForm", professor);
            }

            if (professor.Id == 0) {
                // armazena o cliente em memória
                _context.Professores.Add(professor);
            } else {
                var professorInDb = _context.Professores.Single(c => c.Id == professor.Id);

                professorInDb.Nome = professor.Nome;
                professorInDb.CPF = professor.CPF;
                professorInDb.Matricula = professor.Matricula;
                professorInDb.DataNascimento = professor.DataNascimento;
                professorInDb.Email = professor.Email;
                professorInDb.Telefone = professor.Telefone;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        [Authorize(Roles = RoleName.CanManageData)]
        public ActionResult Edit(int id) {
            var professor = _context.Professores.SingleOrDefault(c => c.Id == id);

            if (professor == null)
                return HttpNotFound();


            return View("ProfessorForm", professor);
        }

        [Authorize(Roles = RoleName.CanManageData)]
        public ActionResult Delete(int id) {
            var professor = _context.Professores.SingleOrDefault(c => c.Id == id);

            if (professor == null)
                return HttpNotFound();

            _context.Professores.Remove(professor);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}