using FluentValidation;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Validators.Usuario{

    public class UsuarioRedefinirSenhaDTOValidator : AbstractValidator<UsuarioRedefinirSenhaDTO>
    {
        public UsuarioRedefinirSenhaDTOValidator()
        {
            RuleFor(x => x.Token)
                .NotEmpty().WithMessage("O código de recuperação de senha é obrigatório");

            RuleFor(x => x.NovaSenha)
                .NotEmpty().WithMessage("A senha é obrigatória.");
            
        }
    }
}