using FluentValidation;

namespace CleanArchitecture.Application.Features.Directors.Commands.CreateDirector
{
    public class CreateCommandValidator : AbstractValidator<CreateDirectorCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("{Name} no puede ser nulo");

            RuleFor(x => x.Surname)
                .NotEmpty()
                .WithMessage("{Name} no puede ser nulo");
        }
    }
}
