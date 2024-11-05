using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Application.Features;
using TodoProject.Application.Features.TodoItems.CreateTodoItem;
using ToDoProject.Domain;

namespace TodoProject.Application.Profiles
{
    public class Mappingprofile : Profile
    {
        public Mappingprofile() 
        {
            CreateMap<TodoItem, TodoItemListDTO>().ReverseMap();
            CreateMap<TodoItem, TodoItemDetailDTO>().ReverseMap();
            CreateMap<TodoItem, CreateTodoItemCommand>().ReverseMap();

        }

    }
}
