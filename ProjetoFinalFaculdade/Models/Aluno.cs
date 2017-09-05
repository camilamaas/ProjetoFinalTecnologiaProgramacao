using System.Collections.Generic;

namespace ProjetoFinalFaculdade.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public int Matricula { get; set; }

        public string DataNascimento { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }

        public Curso Curso { get; set; }

        public int Fase { get; set; }
    }
}