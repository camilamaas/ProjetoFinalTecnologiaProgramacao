using ProjetoFinalFaculdade.Models;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class ProfessorController : Controller
    {

        private ApplicationDbContext _context;
        //public List<Professor> Professores = new List<Professor>
        //{
        //    new Professor {Id = 1, Nome="Rodrigo", Matricula = 1, DataNascimento = "22/06/1978", Email = "rodrigo@catolica", Telefone = 12341234},
        //    new Professor {Id = 2, Nome="Leonardo", Matricula = 2, DataNascimento = "05/09/1980", Email = "leonardo@catolica", Telefone = 15698745}
        //};

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
            var professor = _context.Professores.SingleOrDefault(a => a.Id == id);
            if (professor == null)
            {
                return HttpNotFound();
            }

            return View(professor);
        }
    }
}