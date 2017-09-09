using ProjetoFinalFaculdade.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class DisciplinaController : Controller
    {
        private ApplicationDbContext _context;

        //public List<Disciplina> Disciplinas = new List<Disciplina>
        //{
        //    new Disciplina {Id = 1, Nome="Programação 1", Ementa = "Desenvolver soluções.", CargaHoraria = 60},
        //    new Disciplina {Id = 2, Nome="Banco de dados 1", Ementa = "Entender SGBD.", CargaHoraria = 120 }
        //};

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
            var disciplinas = _context.Disciplinas.Include(a => a.Professor).ToList();
            return View(disciplinas);
        }

        public ActionResult Details(int id)
        {
            var disciplina = _context.Disciplinas.Include(a => a.Professor).SingleOrDefault(a => a.Id == id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }
    }
}