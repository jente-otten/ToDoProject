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
    public class GetAllTodoTasksQueryHandler : IRequestHandler<GetAllTodoTasksQuery, List<TodoTaskListDTO>>
    {
        private readonly IAsyncRepository<TodoTask> _todoTaskRepository;
        private readonly IMapper _mapper;

        public GetAllTodoTasksQueryHandler(IAsyncRepository<TodoTask> todoTaskRepository, IMapper mapper)
        {
            _todoTaskRepository = todoTaskRepository;
            _mapper = mapper;
        }

        public async Task<List<TodoTaskListDTO>> Handle(GetAllTodoTasksQuery request, CancellationToken cancellationToken)
        {
            List<TodoTask> List = (await _todoTaskRepository.GetAllAsync()).OrderBy(x => x.DueDate).ToList();
            return _mapper.Map<List<TodoTaskListDTO>>(List);

        }
    }
}
