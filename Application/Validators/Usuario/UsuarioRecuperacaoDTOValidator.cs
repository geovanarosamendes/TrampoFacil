using FluentValidation;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Validators.Usuario{
    public class UsuarioReadDTOValidator : AbstractValidator<UsuarioRecuperacaoDTO>
    {
        public UsuarioReadDTOValidator()
        {
             RuleFor(x => x.Login)
                .NotNull().WithMessage("Dados obrigatórios! Insira o Login de acesso definido no cadastro");
                
        }
    }
}