using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalFaculdade.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Ementa")]
        public string Ementa { get; set; }

        [Required]
        [Display(Name = "Duração (em anos)")]
        public string Duracao { get; set; }

        [Required]
        [Display(Name = "Mensalidade")]
        public double? Mensalidade { get; set; }

        [Required]
        [Display(Name = "Coordenador")]
        public string Coordenador { get; set; }
    }
}