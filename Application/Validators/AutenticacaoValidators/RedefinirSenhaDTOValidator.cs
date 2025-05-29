using FluentValidation;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Validators.Usuario{

    public class RedefinirSenhaDTOValidator : AbstractValidator<RedefinirSenhaDTO>
    {
        public RedefinirSenhaDTOValidator()
        {
            RuleFor(at => at.Token)
                .NotEmpty().WithMessage("O código de recuperação de senha é obrigatório");

            RuleFor(at => at.NovaSenha)
                .NotEmpty().WithMessage("A senha é obrigatória.");
            
        }
    }
}