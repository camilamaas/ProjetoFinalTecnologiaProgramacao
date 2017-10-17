using ProjetoFinalFaculdade.Models;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class ProfessorController : Controller
    {

        private ApplicationDbContext _context;
      

        public ProfessorController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Professor
        public ActionResult Index()
        {
            var professores = _context.Professores.ToList();
            return View(professores);
        }

        public ActionResult Details(int id)
        {
            var professor = _context.Professores.SingleOrDefault(p => p.Id == id);
            if (professor == null)
            {
                return HttpNotFound();
            }

            return View(professor);
        }

        public ActionResult New()
        {
            var professor = new Professor();

            return View("ProfessorForm", professor);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Professor professor) // recebemos um cliente
        {
            if (professor.Id == 0)
            {
                // armazena o cliente em memória
                _context.Professores.Add(professor);
            }
            else
            {
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

        public ActionResult Edit(int id)
        {
            var professor = _context.Professores.SingleOrDefault(c => c.Id == id);

            if (professor == null)
                return HttpNotFound();


            return View("ProfessorForm", professor);
        }
    }
}