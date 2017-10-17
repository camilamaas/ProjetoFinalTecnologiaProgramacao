using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalFaculdade.Models
{
    public class Disciplina
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Ementa")]
        public string Ementa { get; set; }

        [Display(Name = "Carga horária (em horas)")]
        public double CargaHoraria { get; set; }

        public Professor Professor { get; set; }

        //Chave estrangeira
        [Display(Name = "Professor")]
        public int ProfessorId { get; set; }

        public Curso Curso { get; set; }

        //Chave estrangeira
        [Display(Name = "Curso")]
        public int CursoId { get; set; }

    }
}