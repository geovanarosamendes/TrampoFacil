using FluentValidation;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Validators
{

    public class UsuarioDTOValidator : AbstractValidator<UsuarioDTO>
    {
        public UsuarioDTOValidator()
        {

            RuleFor(u => u.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório")
                .MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("O nome não pode ter mais que 80 caracteres");

            RuleFor(u => u.Idade)
                .NotEmpty().WithMessage("A idade é obrigatória");
                

            RuleFor(u => u.Cidade)
                .NotEmpty().WithMessage("O nome da Cidade é obrigatório")
                .MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("O nome não pode ter mais que 80 caracteres");


            RuleFor(u => u.Bairro)
                .NotEmpty().WithMessage("O Bairro é obrigatório")
                .MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("O nome não pode ter mais que 80 caracteres");


            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório.")
                .EmailAddress().WithMessage("Formato de e-mail inválido.");

            RuleFor(u => u.Telefone)
                .NotEmpty().WithMessage("O Telefone é obrigatório")
                .MinimumLength(8).WithMessage("O Telefone deve ter no mínimo 8 caracteres")
                .MaximumLength(15).WithMessage("O Telefone não pode ter mais que 15 caracteres");

            RuleFor(u => u.Login)
                .NotEmpty().WithMessage("A definição de Login é obrigatória")
                .MinimumLength(10).WithMessage("O Login deve ter no mínimo 10 caracteres")
                .MaximumLength(80).WithMessage("O Login não pode ter mais que 80 caracteres");

            RuleFor(u => u.Senha)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(6).WithMessage("A senha deve ter no mínimo 6 caracteres.");

            RuleFor(u => u.FotoPerfilUrl)
                .Cascade(CascadeMode.Stop)
                .Must(url => string.IsNullOrEmpty(url) || Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("A URL da foto de perfil está inválida.")
                .Must(url => string.IsNullOrEmpty(url) || url.EndsWith(".jpg") || url.EndsWith(".png") || url.EndsWith(".jpeg"))
                .WithMessage("A foto deve ser .jpg, .png ou .jpeg");


        }
    }

}