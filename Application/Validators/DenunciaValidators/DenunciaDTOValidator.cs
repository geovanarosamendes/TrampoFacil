using FluentValidation;
using TrampoFacil.Application.DTOs.Denuncias;

namespace TrampoFacil.Application.Validators
{
    public class DenunciaDTOValidator : AbstractValidator<DenunciaDTO>
    {
        public DenunciaDTOValidator()
        {
            RuleFor(d => d.TituloDenuncia)
                .NotEmpty().WithMessage("O Título é obrigatório")
                .MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres")
                .MaximumLength(50).WithMessage("O nome não pode ter mais que 50 caracteres");

            RuleFor(d => d.Motivo)
                .NotEmpty().WithMessage("Campo obrigatório")
                .MinimumLength(3).WithMessage("Mínimo 5 caracteres")
                .MaximumLength(200).WithMessage("O limite é 200 caracteres");

        }
    }
}