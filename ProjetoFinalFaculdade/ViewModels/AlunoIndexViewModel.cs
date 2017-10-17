using ProjetoFinalFaculdade.Models;
using System.Collections.Generic;

namespace ProjetoFinalFaculdade.ViewModels
{
    public class AlunoIndexViewModel
    {

        public List<Curso> Cursos { get; set; }
        public Aluno Aluno { get; set; }

        public string Title
        {
            get
            {
                if (Aluno != null && Aluno.Id != 0)
                    return "Editar Aluno";

                return "Novo Aluno";
            }
        }
    }
}