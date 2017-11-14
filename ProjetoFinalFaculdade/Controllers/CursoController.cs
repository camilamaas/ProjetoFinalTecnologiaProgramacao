using ProjetoFinalFaculdade.Models;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class CursoController : Controller
    {

        private ApplicationDbContext _context;


        public CursoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Curso
        public ActionResult Index()
        {

            var cursos = _context.Cursos.ToList();
            return View(cursos);
        }

        public ActionResult Details(int id)
        {
            var curso = _context.Cursos.SingleOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return HttpNotFound();
            }

            return View(curso);
        }

        public ActionResult New()
        {
            var curso = new Curso();

            return View("CursoForm", curso);
        }

        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Curso curso) // recebemos um cliente
        {

            if (!ModelState.IsValid)
            {
                return View("CursoForm", curso);
            }

            if (curso.Id == 0)
            {
                // armazena o cliente em memória
                _context.Cursos.Add(curso);
            }
            else
            {
                var cursoInDb = _context.Cursos.Single(c => c.Id == curso.Id);

                cursoInDb.Nome = curso.Nome;
                cursoInDb.Ementa = curso.Ementa;
                cursoInDb.Duracao = curso.Duracao;
                cursoInDb.Mensalidade = curso.Mensalidade;
                cursoInDb.Coordenador = curso.Coordenador;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var curso = _context.Cursos.SingleOrDefault(c => c.Id == id);

            if (curso == null)
                return HttpNotFound();


            return View("CursoForm", curso);
        }

        public ActionResult Delete(int id) {
            var curso = _context.Cursos.SingleOrDefault(c => c.Id == id);

            if (curso == null)
                return HttpNotFound();

            _context.Cursos.Remove(curso);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}