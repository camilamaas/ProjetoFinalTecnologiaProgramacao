using ProjetoFinalFaculdade.Models;
using System.Collections.Generic;

namespace ProjetoFinalFaculdade.ViewModels
{
    public class DisciplinaIndexViewModel
    {
        public List<Professor> Professores { get; set; }
        public List<Curso> Cursos { get; set; }
        public Disciplina Disciplina { get; set; }

        public string Title
        {
            get
            {
                if (Disciplina != null && Disciplina.Id != 0)
                    return "Editar Disciplina";

                return "Nova Disciplina";
            }
        }
    }
}