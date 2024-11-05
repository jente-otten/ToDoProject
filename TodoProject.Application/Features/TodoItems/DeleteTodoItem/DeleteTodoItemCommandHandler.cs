using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Application.Contracts.Persistence;
using ToDoProject.Domain;

namespace TodoProject.Application.Features.TodoItems.DeleteTodoItem
{
    public class DeleteTodoItemCommandHandler : IRequestHandler<DeleteTodoItemCommand>
    {
        private readonly IAsyncRepository<TodoItem> _todoTaskRepository;
        private readonly IMapper _mapper;

        public DeleteTodoItemCommandHandler(IAsyncRepository<TodoItem> todoTaskRepository, IMapper mapper)
        {
            _todoTaskRepository = todoTaskRepository;
            _mapper = mapper;
        }

        public async Task Handle(DeleteTodoItemCommand request, CancellationToken cancellationToken)
        {
            var TodoItemToDelete = await _todoTaskRepository.GetByIdAsync(request.Id);
            await _todoTaskRepository.DeleteAsync(TodoItemToDelete);
        }
    }
}
