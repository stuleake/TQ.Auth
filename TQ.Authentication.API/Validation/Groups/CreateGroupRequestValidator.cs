﻿using FluentValidation;
using TQ.Authentication.Core.Requests.Groups;

namespace TQ.Authentication.API.Validation
{
    /// <summary>
    /// Fluent validation class for the <see cref="CreateGroupRequest"/>
    /// </summary>
    public class CreateGroupRequestValidator : AbstractValidator<CreateGroupRequest>
    {
        public CreateGroupRequestValidator()
        {
            RuleFor(req => req.Name).NotNull().NotEmpty().MaximumLength(120).NotStartOrEndWithWhiteSpace();
            RuleFor(req => req.Description).NotNull().NotEmpty().MaximumLength(1024).NotStartOrEndWithWhiteSpace();
            RuleFor(req => req.ServiceUrl).NotNull().NotEmpty().MaximumLength(500).NotStartOrEndWithWhiteSpace();
        }
    }
}