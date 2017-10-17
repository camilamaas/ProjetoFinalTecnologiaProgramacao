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

        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Matricula")]
        public int Matricula { get; set; }

        [Display(Name = "Data de nascimento")]
        public string DataNascimento { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        public int Telefone { get; set; }

        [Display(Name = "Curso")]
        public Curso Curso { get; set; }

        //Chave estrangeira
        public int CursoId { get; set; }

        [Display(Name = "Fase")]
        public int Fase { get; set; }
    }
}