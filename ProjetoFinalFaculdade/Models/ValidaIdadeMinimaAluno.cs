using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalFaculdade.Models
{
    public class ValidaIdadeMinimaAluno : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var aluno = (Aluno)validationContext.ObjectInstance;

            if (aluno.DataNascimento == null)
            {
                return new ValidationResult("O campo Data de Nascimento é obrigatório");
            }

            var idade = DateTime.Today.Year - aluno.DataNascimento.Value.Year;

            return (idade >= 18) ? ValidationResult.Success : new ValidationResult("O aluno deve ter no mínimo 18 anos");
        }
    }
}