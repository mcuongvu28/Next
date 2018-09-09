using FluentValidation;
using Next.ECommerce.Application.Users.Commands;

namespace Next.ECommerce.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.UserId)
                .MaximumLength(5).WithMessage("User Id has max. length of 10 characters")
                .NotEmpty().WithMessage("User Id is required.");

            RuleFor(x => x.UserName)
                .MaximumLength(30).WithMessage("User name has max. length of 256 characters")
                .NotEmpty().WithMessage("User name is required.");

            RuleFor(x => x.Password)
                .MaximumLength(5).WithMessage("Password has max. length of 256 characters")
                .NotEmpty().WithMessage("Password is required.");
        }
    }
}