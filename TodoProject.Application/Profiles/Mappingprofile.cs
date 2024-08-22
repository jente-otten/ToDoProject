using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Application.Features;
using ToDoProject.Domain;

namespace TodoProject.Application.Profiles
{
    public class Mappingprofile : Profile
    {
        public Mappingprofile() 
        {
            CreateMap<TodoTask, TodoTaskListDTO>().ReverseMap();
            CreateMap<TodoTask, TodoTaskDetailDTO>().ReverseMap();

        }

    }
}
