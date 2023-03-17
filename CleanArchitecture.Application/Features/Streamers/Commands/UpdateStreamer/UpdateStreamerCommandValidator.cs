﻿using FluentValidation;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
    public class UpdateStreamerCommandValidator : AbstractValidator<UpdateStreamerCommand>
    {
        public UpdateStreamerCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotNull().WithMessage("{Name} no permite valores nulos");
            RuleFor(p => p.Url)
                .NotNull().WithMessage("{Url} no permite valores nulos");
        }
    }
}
