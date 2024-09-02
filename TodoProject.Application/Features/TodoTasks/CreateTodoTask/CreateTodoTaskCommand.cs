using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoProject.Domain;

namespace TodoProject.Application.Features.TodoTasks.CreateTodoTask
{
    public class CreateTodoTaskCommand: IRequest<Guid>
    {
       public string Title { get; set; } 
        public DateOnly DueDate { get; set; }
        public User? CreatedBy { get; set; }
    }
}
