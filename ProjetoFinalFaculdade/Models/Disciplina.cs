using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinalFaculdade.Models
{
    public class Disciplina
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Ementa { get; set; }

        public double CargaHoraria { get; set; }

        public Professor Professor { get; set; }

        //Chave estrangeira
        public int ProfessorId { get; set; }

        public Curso Curso { get; set; }

        //Chave estrangeira
        public int CursoId { get; set; }

    }
}