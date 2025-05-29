using FluentValidation;
using TrampoFacil.Application.DTOs.InfoPro;

namespace TrampoFacil.Application.Validators
{
    public class InfoProDTOValidator : AbstractValidator<InfoProDTO>
    {
        public InfoProDTOValidator()
        {
            RuleFor(ip => ip.Profissao)
                .NotEmpty().WithMessage("Campo obrigatório")
                .MinimumLength(3).WithMessage("Deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("Não pode ter mais que 80 caracteres");

            RuleFor(ip => ip.Escolaridade)
                .NotEmpty().WithMessage("Campo obrigatório")
                .MinimumLength(3).WithMessage("Deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("Não pode ter mais que 80 caracteres");

            RuleFor(ip => ip.Cursos)
                .MaximumLength(200).WithMessage("Não pode ter mais que 200 caracteres");


            RuleFor(ip => ip.Experiencias)
                .NotEmpty().WithMessage("Campo obrigatório")
                .MinimumLength(3).WithMessage("Deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("Não pode ter mais que 80 caracteres");

            RuleFor(ip => ip.Habilidades)
                .NotEmpty().WithMessage("Campo obrigatório")
                .MinimumLength(3).WithMessage("Deve ter no mínimo 3 caracteres")
                .MaximumLength(80).WithMessage("Não pode ter mais que 80 caracteres");

        }
    }
}