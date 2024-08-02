using FluentValidation;
using TaskManagementSystem.Api.DTOs;

namespace TaskManagementSystem.Api.Validators
{
    public class TaskDtoValidator : AbstractValidator<TaskDto>
    {
        public TaskDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .Length(1, 100).WithMessage("Title length must be between 1 and 100 characters.");

            RuleFor(x => x.DueDate)
                .NotEmpty().WithMessage("Due Date is required.");

            RuleFor(x => x.Status)
                .NotEmpty().WithMessage("Status is required.")
                .Length(1, 50).WithMessage("Status length must be between 1 and 50 characters.");

            RuleFor(x => x.AssignedToEmployeeId)
                .NotEmpty().WithMessage("Assigned To Employee ID is required.");
        }
    }
}
