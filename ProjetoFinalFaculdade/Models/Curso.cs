using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalFaculdade.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Display(Name = "Ementa")]
        public string Ementa { get; set; }

        [Display(Name = "Duracao")]
        public string Duracao { get; set; }

        [Display(Name = "Mensalidade")]
        public double Mensalidade { get; set; }

        [Display(Name = "Coordenador")]
        public string Coordenador { get; set; }
    }
}