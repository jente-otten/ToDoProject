using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoProject.Domain;

namespace TodoProject.Application.Features.TodoItems.UpdateTodoItem
{
    public class UpdateTodoItemCommand: IRequest
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public DateOnly DueDate { get; set; }
       public bool IsCompleted { get; set; }
        public TodoItem? Parent { get; set; }

    }
}
