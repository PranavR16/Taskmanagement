using FluentValidation;
using TaskManagementSystem.Api.DTOs;

namespace TaskManagementSystem.Api.Validators
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(1, 100).WithMessage("Name length must be between 1 and 100 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email address.");

            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("Role is required.")
                .Length(1, 50).WithMessage("Role length must be between 1 and 50 characters.");
        }
    }
}
