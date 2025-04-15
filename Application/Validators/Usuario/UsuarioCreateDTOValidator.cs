using FluentValidation;
using TrampoFacil.Application.DTOs.Usuario;

namespace TrampoFacil.Application.Validators.Usuario{

    public class UsuarioCreateDTOValidator : AbstractValidator<UsuarioCreateDTO>
    {
        public UsuarioCreateDTOValidator()
        {

            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório")
                .MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("O nome não pode ter mais que 80 caracteres");

            RuleFor(x => x.Idade)
                .NotEmpty().WithMessage("A idade é obrigatória");
                

            RuleFor(x => x.Cidade)
                .NotEmpty().WithMessage("O nome da Cidade é obrigatório")
                .MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("O nome não pode ter mais que 80 caracteres");


            RuleFor(x => x.Bairro)
                .NotEmpty().WithMessage("O Bairro é obrigatório")
                .MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("O nome não pode ter mais que 80 caracteres");


            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório.")
                .EmailAddress().WithMessage("Formato de e-mail inválido.");

            RuleFor(x => x.Telefone)
                .NotEmpty().WithMessage("O Telefone é obrigatório")
                .MinimumLength(8).WithMessage("O Telefone deve ter no mínimo 8 caracteres")
                .MaximumLength(15).WithMessage("O Telefone não pode ter mais que 15 caracteres");

            RuleFor(x => x.Login)
                .NotEmpty().WithMessage("A definição de Login é obrigatória")
                .MinimumLength(10).WithMessage("O Login deve ter no mínimo 10 caracteres")
                .MaximumLength(80).WithMessage("O Login não pode ter mais que 80 caracteres");

            RuleFor(x => x.SenhaHash)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(6).WithMessage("A senha deve ter no mínimo 6 caracteres.");


        }
    }

}