using FluentValidation;
using TrampoFacil.Application.DTOs;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Validators{
    public class RecuperacaoDTOValidator : AbstractValidator<RecuperacaoDTO>
    {
        public RecuperacaoDTOValidator()
        {
             RuleFor(at => at.Login)
                .NotNull().WithMessage("Dados obrigatórios! Insira o Login de acesso definido no cadastro");
                
        }
    }
}