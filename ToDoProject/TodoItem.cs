using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject.Domain
{
    public class TodoItem
    {
        public TodoItem(string title, string description, Guid id, DateOnly dueDate, DateOnly plannedDate, TodoItem? parent)
        {
            Title = title;
            Description = description;
            Id = id;
            DueDate = dueDate;
            PlannedDate = plannedDate;
            Parent = parent;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly PlannedDate { get; set; }
        public TodoItem? Parent { get; set; }

    }
}
