using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalFaculdade.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required]
        [Display(Name = "Matricula")]
        public int Matricula { get; set; }

        [ValidaIdadeMinimaAluno]
        [Display(Name = "Data de nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        public int Telefone { get; set; }
        
        public Curso Curso { get; set; }

        //Chave estrangeira
        [Required]
        [Display(Name = "Curso")]
        public int CursoId { get; set; }

        [Required]
        [Display(Name = "Fase")]
        public int Fase { get; set; }
    }
}