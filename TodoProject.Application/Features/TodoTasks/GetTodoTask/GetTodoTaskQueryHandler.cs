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
    public class GetTodoTaskQueryHandler : IRequestHandler<GetTodoTaskQuery, TodoTaskDetailDTO>
    {
        private readonly IAsyncRepository<TodoTask> _todoTaskRepository;
        private readonly IMapper _mapper;

        public GetTodoTaskQueryHandler(IAsyncRepository<TodoTask> todoTaskRepository, IMapper mapper)
        {
            _todoTaskRepository = todoTaskRepository;
            _mapper = mapper;
        }

        public async Task<TodoTaskDetailDTO> Handle(GetTodoTaskQuery request, CancellationToken cancellationToken)
        {
            TodoTask todo = await _todoTaskRepository.GetByIdAsync(request.Id);
            return _mapper.Map<TodoTaskDetailDTO>(todo);
        }
    }
}
