

using FluentValidation;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Validators{

    public class LoginDTOValidator : AbstractValidator<LoginDTO>
    {
        public LoginDTOValidator()
        {
            RuleFor(at => at.Login)
                .NotEmpty().WithMessage("Dados obrigatórios! Insira o Login de acesso definido no cadastro");


            RuleFor(at => at.Senha)
              .NotEmpty().WithMessage("A senha é obrigatória.");
        }
    }
}