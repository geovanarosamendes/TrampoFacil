using FluentValidation;
using TrampoFacil.Application.DTOs.Anuncio;

namespace TrampoFacil.Application.Validators
{
    public class AnuncioDTOVAlidator : AbstractValidator<AnuncioDTO>
    {
        public AnuncioDTOVAlidator()
        {
            RuleFor(an => an.Titulo)
                .NotEmpty().WithMessage("Campo obrigatório")
                .MinimumLength(3).WithMessage("O Título deve ter no mínimo 3 caracteres")
                .MaximumLength(50).WithMessage("O Título não pode ter mais que 50 caracteres");

            RuleFor(an => an.Descricao)
                .NotEmpty().WithMessage("Campo obrigatório")
                .MinimumLength(3).WithMessage("A descrição deve ter no mínimo 3 caracteres")
                .MaximumLength(250).WithMessage("A descrição não pode ter mais que 250 caracteres");


            RuleFor(an => an.Telefone)
                .NotEmpty().WithMessage("Campo obrigatório")
                .MinimumLength(8).WithMessage("Mínimo 8 caracteres")
                .MaximumLength(15).WithMessage("O Telefone não pode ter mais que 50 caracteres");


            RuleFor(an => an.Cobranca)
                .NotEmpty().WithMessage("Campo obrigatório");


            RuleFor(an => an.Valor)
                .NotEmpty().WithMessage("Campo obrigatório");

        }
    }
}