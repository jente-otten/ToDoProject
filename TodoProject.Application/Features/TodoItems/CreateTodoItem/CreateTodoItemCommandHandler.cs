using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Application.Contracts.Persistence;
using ToDoProject.Domain;

namespace TodoProject.Application.Features.TodoItems.CreateTodoItem
{
    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, Guid>
    {

        private readonly IAsyncRepository<TodoItem> _todoTaskRepository;
        private readonly IMapper _mapper;

        public CreateTodoItemCommandHandler(IAsyncRepository<TodoItem> todoTaskRepository, IMapper mapper)
        {
            _todoTaskRepository = todoTaskRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            TodoItem TaskToAdd = _mapper.Map<TodoItem>(request);
            var validator = new CreateTodoItemCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0) 
            {
                throw new Exceptions.ValidationException(validationResult);
            }
            await _todoTaskRepository.AddAsync(TaskToAdd);
            return TaskToAdd.Id;
             
        }
    }
}
