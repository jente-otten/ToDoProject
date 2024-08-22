using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ToDoProject.Domain
{
    public record TodoTask(string Title,
        DateOnly DueDate,
        User CreatedBy) :
        Todo(Guid.NewGuid(),
            Title, 
            DateOnly.FromDateTime(DateTime.Now),
            CreatedBy);
}
