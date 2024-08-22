using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject.Domain
{

    public abstract record Todo(Guid Id, 
        string Title,
        DateOnly CreatedDate,
        User CreatedBy,
        bool IsCompleted = false,
        bool IsDeleted = false)
    {
        public Todo? Parent { get; init; }
    }
}
