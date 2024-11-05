using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Application.Contracts.Persistence;
using ToDoProject.Domain;

namespace TodoProject.Application.Features.TodoItems.UpdateTodoItem
{
    public class UpdateTodoItemCommandHandler : IRequestHandler<UpdateTodoItemCommand>
    {
        private readonly IAsyncRepository<TodoItem> _todoTaskRepository;
        private readonly IMapper _mapper;

        public UpdateTodoItemCommandHandler(IAsyncRepository<TodoItem> todoTaskRepository, IMapper mapper)
        {
            _todoTaskRepository = todoTaskRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateTodoItemCommand request, CancellationToken cancellationToken)
        {
            var taskToUpdate = await _todoTaskRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, taskToUpdate,typeof(UpdateTodoItemCommand),typeof(TodoItem));
            await _todoTaskRepository.UpdateAsync(taskToUpdate);
                }
    }
}
