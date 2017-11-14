using ProjetoFinalFaculdade.Models;
using ProjetoFinalFaculdade.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;
using System.Linq;

namespace ProjetoFinalFaculdade.Controllers {
    public class AlunoController : Controller {
        private ApplicationDbContext _context;

        public AlunoController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
        }

        // GET: Aluno
        public ActionResult Index() {
            var alunos = _context.Alunos.Include(c => c.Curso).ToList();
            return View(alunos);
        }

        public ActionResult Details(int id) {

            var aluno = _context.Alunos.Include(c => c.Curso).SingleOrDefault(a => a.Id == id);
            if (aluno == null) {
                return HttpNotFound();
            }

            return View(aluno);
        }

        public ActionResult New() {
            var cursos = _context.Cursos.ToList();
            var viewModel = new AlunoIndexViewModel {
                Aluno = new Aluno(),
                Cursos = cursos
            };

            return View("AlunoForm", viewModel);
        }

        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Aluno aluno) // recebemos um aluno
        {
            if (!ModelState.IsValid) {
                var viewModel = new AlunoIndexViewModel {
                    Aluno = aluno,
                    Cursos = _context.Cursos.ToList()
                };

                return View("AlunoForm", viewModel);
            }

            if (aluno.Id == 0) {
                // armazena o cliente em memória
                _context.Alunos.Add(aluno);
            } else {
                var alunoInDb = _context.Alunos.Single(c => c.Id == aluno.Id);

                alunoInDb.Nome = aluno.Nome;
                alunoInDb.CPF = aluno.CPF;
                alunoInDb.Matricula = aluno.Matricula;
                alunoInDb.DataNascimento = aluno.DataNascimento;
                alunoInDb.Email = aluno.Email;
                alunoInDb.Telefone = aluno.Telefone;
                alunoInDb.CursoId = aluno.CursoId;
                alunoInDb.Fase = aluno.Fase;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id) {
            var aluno = _context.Alunos.SingleOrDefault(c => c.Id == id);

            if (aluno == null)
                return HttpNotFound();

            var viewModel = new AlunoIndexViewModel {
                Aluno = aluno,
                Cursos = _context.Cursos.ToList()
            };

            return View("AlunoForm", viewModel);
        }


        public ActionResult Delete(int id) {
            var aluno = _context.Alunos.SingleOrDefault(c => c.Id == id);

            if (aluno == null)
                return HttpNotFound();

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }

    }
}