using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Application.Contracts.Persistence;

namespace TodoProject.Application.Features.TodoItems.CreateTodoItem
{
    public class CreateTodoItemCommandValidator: AbstractValidator<CreateTodoItemCommand>
    {
        private ITodoItemRepository _todoTaskRepository;
        public CreateTodoItemCommandValidator(ITodoItemRepository todoTaskRepository)
        {
            _todoTaskRepository = todoTaskRepository;
        }

        public CreateTodoItemCommandValidator()
        {
            RuleFor(p=>p.Title).NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");

            RuleFor(p => p.DueDate).NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateOnly.FromDateTime(DateTime.Now));
            RuleFor(p => p).MustAsync(IsTodoItemTitleAndDueDateUnique)
                .WithMessage("A task with the same name and date already exists.");
        }

        private async Task<bool> IsTodoItemTitleAndDueDateUnique(CreateTodoItemCommand e, CancellationToken token)
        {
            return !(await _todoTaskRepository.IsTodoItemTitleAndDueDateUnique(e.Title, e.DueDate));
        }

    }
}
