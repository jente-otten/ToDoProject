using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoProject.Domain;

namespace TodoProject.Application.Features
{
    public class GetAllTodoItemsQuery : IRequest<List<TodoItemListDTO>>
    {
    }
}
