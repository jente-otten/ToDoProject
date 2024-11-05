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
    public class GetAllTodoItemsQueryHandler : IRequestHandler<GetAllTodoItemsQuery, List<TodoItemListDTO>>
    {
        private readonly IAsyncRepository<TodoItem> _todoTaskRepository;
        private readonly IMapper _mapper;

        public GetAllTodoItemsQueryHandler(IAsyncRepository<TodoItem> todoTaskRepository, IMapper mapper)
        {
            _todoTaskRepository = todoTaskRepository;
            _mapper = mapper;
        }

        public async Task<List<TodoItemListDTO>> Handle(GetAllTodoItemsQuery request, CancellationToken cancellationToken)
        {
            List<TodoItem> List = (await _todoTaskRepository.GetAllAsync()).OrderBy(x => x.DueDate).ToList();
            return _mapper.Map<List<TodoItemListDTO>>(List);

        }
    }
}
