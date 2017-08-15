using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinalFaculdade.Models
{
    public class Curso
    {

        public string Nome { get; set; }

        public string Ementa { get; set; }

        public List<Disciplina> DisciplinasPadrão { get; set; }

        public List<Aluno> Alunos { get; set; }

        public string Duracao { get; set; }

        public double Mensalidade { get; set; }

        public string Coordenador { get; set; }
    }
}