

using FluentValidation;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Validators.Usuario{

    public class UsuarioLoginDTOValidator : AbstractValidator<UsuarioLoginDTO>
    {
        public UsuarioLoginDTOValidator()
        {
            RuleFor(x => x.Login)
                .NotEmpty().WithMessage("Dados obrigatórios! Insira o Login de acesso definido no cadastro");


            RuleFor(x => x.SenhaHash)
              .NotEmpty().WithMessage("A senha é obrigatória.");
        }
    }
}