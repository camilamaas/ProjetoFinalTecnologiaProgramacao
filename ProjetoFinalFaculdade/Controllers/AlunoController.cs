using ProjetoFinalFaculdade.Models;
using ProjetoFinalFaculdade.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;
using System.Linq;

namespace ProjetoFinalFaculdade.Controllers
{
    public class AlunoController : Controller
    {
        private ApplicationDbContext _context;

        //public List<Aluno> Alunos = new List<Aluno>
        //{
        //    new Aluno {Id = 1, Nome="Camila", CPF = "001", Matricula = 1, DataNascimento = "10/11/1998", Email = "camila@catolica", Telefone = 12341234, Fase = 1 },
        //    new Aluno {Id = 2, Nome="Joao", CPF = "002", Matricula = 2, DataNascimento = "10/01/1997", Email = "joao@catolica", Telefone = 12341234, Fase = 1 }
        //};

        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Aluno
        public ActionResult Index()
        {
            var alunos = _context.Alunos.Include(a => a.Curso).ToList();
            return View(alunos);
        }

        public ActionResult Details(int id)
        {

            var aluno = _context.Alunos.Include(a => a.Curso).SingleOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }
    }
}