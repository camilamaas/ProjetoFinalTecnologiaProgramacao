using ProjetoFinalFaculdade.Models;
using ProjetoFinalFaculdade.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class DisciplinaController : Controller
    {
        private ApplicationDbContext _context;

        
        public DisciplinaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Disciplina
        public ActionResult Index()
        {
            var disciplinas = _context.Disciplinas.Include(p => p.Professor).Include(c => c.Curso).ToList();
            return View(disciplinas);
        }

        public ActionResult Details(int id)
        {
            var disciplina = _context.Disciplinas.Include(p => p.Professor).Include(c => c.Curso).SingleOrDefault(d => d.Id == id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        public ActionResult New()
        {
            var professores = _context.Professores.ToList();
            var cursos = _context.Cursos.ToList();
            var viewModel = new DisciplinaIndexViewModel
            {
                Professores = professores,
                Cursos = cursos
            };

            return View("DisciplinaForm", viewModel);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Disciplina disciplina) // recebemos um cliente
        {
            if (disciplina.Id == 0)
            {
                // armazena o cliente em memória
                _context.Disciplinas.Add(disciplina);
            }
            else
            {
                var disciplinaInDb = _context.Disciplinas.Single(c => c.Id == disciplina.Id);

                disciplinaInDb.Nome = disciplina.Nome;
                disciplinaInDb.CargaHoraria = disciplina.CargaHoraria;
                disciplinaInDb.ProfessorId = disciplina.ProfessorId;
                disciplinaInDb.CursoId = disciplina.CursoId;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var disciplina = _context.Disciplinas.SingleOrDefault(c => c.Id == id);

            if (disciplina == null)
                return HttpNotFound();

            var viewModel = new DisciplinaIndexViewModel
            {
                Disciplina = disciplina,
                Cursos = _context.Cursos.ToList()
            };

            return View("AlunoForm", viewModel);
        }
    }
}