using FluentValidation;
using GRU.Poc.Project.Application.Commands.Request;

namespace GRU.Poc.Project.Application.Validations
{
    public class AuthenticationValidation : AbstractValidator<AuthenticationCommandRequest>
    {
    }
}
