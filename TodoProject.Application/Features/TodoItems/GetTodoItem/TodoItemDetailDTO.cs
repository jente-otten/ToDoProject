using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoProject.Domain;

namespace TodoProject.Application.Features
{
    public class TodoItemDetailDTO
    {
        public string Title { get; set; } = string.Empty;
        public DateOnly DueDate { get; set; }
    }
}
