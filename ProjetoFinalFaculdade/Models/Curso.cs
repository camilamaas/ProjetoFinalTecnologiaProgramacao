using System.Collections.Generic;

namespace ProjetoFinalFaculdade.Models
{
    public class Curso
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Ementa { get; set; }
        
        
        public string Duracao { get; set; }

        public double Mensalidade { get; set; }

        public string Coordenador { get; set; }
    }
}