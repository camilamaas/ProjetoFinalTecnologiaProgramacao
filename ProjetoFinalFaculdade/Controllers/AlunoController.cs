using ProjetoFinalFaculdade.Models;
using ProjetoFinalFaculdade.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoFinalFaculdade.Controllers
{
    public class AlunoController : Controller
    {
        public List<Aluno> Alunos = new List<Aluno>
        {
            new Aluno {Id = 1, Nome="Camila", CPF = "001", Matricula = 1, DataNascimento = "10/11/1998", Email = "camila@catolica", Telefone = 12341234, Fase = 1 },
            new Aluno {Id = 2, Nome="Joao", CPF = "002", Matricula = 2, DataNascimento = "10/01/1997", Email = "joao@catolica", Telefone = 12341234, Fase = 1 }
        };

        // GET: Aluno
        public ActionResult Index()
        {
            var viewModel = new AlunoIndexViewModel()
            {
               Alunos = Alunos
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if(Alunos.Count < id)
            {
                return HttpNotFound();
            }
            var aluno = Alunos[id - 1];

            return View(aluno);
        }
    }
}