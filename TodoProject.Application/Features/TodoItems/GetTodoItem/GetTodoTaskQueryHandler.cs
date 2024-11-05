using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Application.Contracts.Persistence;
using ToDoProject.Domain;

namespace TodoProject.Application.Features
{
    public class GetTodoItemQueryHandler : IRequestHandler<GetTodoItemQuery, TodoItemDetailDTO>
    {
        private readonly IAsyncRepository<TodoItem> _todoTaskRepository;
        private readonly IMapper _mapper;

        public GetTodoItemQueryHandler(IAsyncRepository<TodoItem> todoTaskRepository, IMapper mapper)
        {
            _todoTaskRepository = todoTaskRepository;
            _mapper = mapper;
        }

        public async Task<TodoItemDetailDTO> Handle(GetTodoItemQuery request, CancellationToken cancellationToken)
        {
            TodoItem todo = await _todoTaskRepository.GetByIdAsync(request.Id);
            return _mapper.Map<TodoItemDetailDTO>(todo);
        }
    }
}
