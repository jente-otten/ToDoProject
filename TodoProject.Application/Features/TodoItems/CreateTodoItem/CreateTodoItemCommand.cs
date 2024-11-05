using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoProject.Domain;

namespace TodoProject.Application.Features.TodoItems.CreateTodoItem
{
    public class CreateTodoItemCommand: IRequest<Guid>
    {
       public required string Title { get; set; } 
       public DateOnly DueDate { get; set; }
    }
}
